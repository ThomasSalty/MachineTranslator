using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite; // ADO.NET provider, open source project

namespace MachineTranslator.Model
{
    class TranslatorDAO
    {
        /// SQLite specifikus connection stringünk.
        private static readonly String connectionString = @"Data Source=tm.db;Version=3;UseUTF8Encoding=True";

        /// <summary>
        /// Fordítási egységekben tároljuk az angol és magyar nyelvű szegmenseket, memóriában: angol / magyar párként
        /// </summary>
        private List<TranslationUnit> translationUnits = new List<TranslationUnit>();
        public bool isSegmentUpdated = false;
        public bool isSegmentInserted = false;

        /// <summary>
        /// Az adatbázisban lévő fordítási egységek lekérése.
        /// </summary>
        /// <returns>fordítási egységek listája</returns>
        public IEnumerable<TranslationUnit> GetTranslationUnits()
        {
            // töröljük a memóriában lévõ értékeket
            translationUnits.Clear();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = conn.CreateCommand();
                
                conn.Open();

                command.CommandText = "SELECT * FROM units ORDER BY english";

                // ExecuteReader()-t használunk ha Select parancsot küldünk és a teljes
                // eredményre (táblázat) kíváncsiak vagyunk. Az eredmény mindig egy
                // valamilyen DataReader objektum.
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TranslationUnit unit = new TranslationUnit();
                    //unit.ID = Convert.ToInt32(reader["id"]);
                    unit.Angol = reader["english"].ToString();
                    unit.Magyar = reader["hungarian"].ToString();                                     

                    translationUnits.Add(unit);                    
                }
            }
            return translationUnits;
        } // GetTranslationUnits               

        public string GetEnglishUnit(TranslationUnit unit)
        {
            string english = null;
                        
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = conn.CreateCommand();

                command.CommandText = "SELECT english FROM units WHERE english=@english";

                // Értéket adok a paraméternek. Ehhez elõbb lérehozok egy új paramétert
                // (Add) és megadom a nevét + SQL szerinti típusát. A név azonos az elõbb definiált
                // SQL parancsban írt névvel. Ezután a keletkezett (SQLite)Parameter objektum
                // Value property-nek értékül adhatjuk a paraméter értékét.
                command.Parameters.Add("english", System.Data.DbType.String).Value = unit.Angol;

                // Ellentétben Java-val a connection létrehozása nem jelent automatikus csatlakozást
                // az adatbázishoz. A tényleges mûveletvégzés elõtt meg kell nyitni a kapcsolatot.
                // Megj.: a végén le kéne zárni is, de ezt a 'using' blokk használata elintézi.
                conn.Open();

                // A parancsot lefuttatom. Az ExecuteScalar() metódust akkor használhatjuk, 
                // ha csak egyetlen eredményt várunk. Itt csak egyetlen 'id' mezõ értékét
                // kértem le. A metódus object-et ad vissza, amit type castolni kell a várt
                // eredménytípusra. Ha nincs eredmény akkor null értéket kapunk.
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    english = result.ToString();
                }
            }
            return english;
        } // GetUnitID

        /// <summary>
        /// Egy fordítási egység (egy forrás és egy cél szegmens) hozzáadása az adatbázishoz.
        /// Ha már létezik a forrás szegmens frissíti az adatbázist, egyébként hozzáad egy új egységet
        /// a units táblához.
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public bool AddOrUpdateTranslationUnit(TranslationUnit unit)
        {
            string english = GetEnglishUnit(unit);

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = conn.CreateCommand();

                if (english != null)
                {
                    // az egység már létezik update sql parancsot kell használni
                    command.CommandText = "UPDATE units SET hungarian=@hungarian "
                        + "WHERE english=@english";
                    //command.Parameters.Add("id", System.Data.DbType.Int32).Value = id;
                    command.Parameters.Add("english", System.Data.DbType.String).Value = unit.Angol;
                    command.Parameters.Add("hungarian", System.Data.DbType.String).Value = unit.Magyar;
                    isSegmentUpdated = true;
                }
                else
                {
                    // az egység még nincs az adatbázisban, insert sql parancs kell
                    command.CommandText = "INSERT INTO units (english, hungarian) "
                        + " VALUES (@english, @hungarian)";
                    command.Parameters.Add("english", System.Data.DbType.String).Value = unit.Angol;
                    command.Parameters.Add("hungarian", System.Data.DbType.String).Value = unit.Magyar;
                    isSegmentInserted = true;
                }

                conn.Open(); // a kapcsolat megnyitása

                // az ExecuteNonQuery() metódus végrehajtja a parancsot, olyan parancsok esetén
                // használjuk ahol nem várunk vissza eredményt (nem Select). A visszatérési értéke
                // a parancs által érintett sorok száma. Ha ez itt nem 1 akkor valami gond van, mivel
                // pont egyetlen egységet szeretnénk beszúrni/módosítani.
                if (command.ExecuteNonQuery() != 1)
                {
                    return false;
                }
            }
            return true;
        } // AddOrUpdateTranslationUnit

        public int GetUnitsNumber(IEnumerable<TranslationUnit> units)
        {
            int length;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                SQLiteCommand unitsLength = conn.CreateCommand();
                unitsLength.CommandText = "SELECT COUNT(*) FROM units";

                conn.Open();

                length = Convert.ToInt32(unitsLength.ExecuteScalar());
            }
            return length;
        }

        public List<string> GetEnglishUnits(IEnumerable<TranslationUnit> units)
        {
            List<string> englishUnits;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                SQLiteCommand selectCommand = conn.CreateCommand();
                selectCommand.CommandText = "SELECT english FROM units";

                conn.Open();

                //length = GetUnitsLength(units);
                englishUnits = new List<string>();

                SQLiteDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    englishUnits.Add(reader["english"].ToString());
                }

            }
            return englishUnits;
        } // GetEnglishUnits

        /// <summary>
        /// Egy fordítási egység (egy forrás és egy cél szegmens) törlése az adatbázisból. 
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public bool DeleteTranslationUnit(string english)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = conn.CreateCommand();

                command.Parameters.Add("english", System.Data.DbType.String).Value = english;
                command.CommandText = "DELETE FROM units WHERE english=@english";
                                
                conn.Open();

                // az ExecuteNonQuery() metódus végrehajtja a parancsot, olyan parancsok esetén
                // használjuk ahol nem várunk vissza eredményt (nem Select). A visszatérési értéke
                // a parancs által érintett sorok száma. Ha ez itt nem 1 akkor valami gond van, mivel
                // pont egyetlen egységet szeretnénk beszúrni/módosítani.
                if (command.ExecuteNonQuery() != 1)
                {
                    return false;
                }
            }
            return true;
        } // DeleteTranslationUnit

    }
}