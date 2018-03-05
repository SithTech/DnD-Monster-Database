using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MonsterDatabaseLibrary
{
    public class Manager
    {
        public int unique_id;
        public List<Monster> monster_list { get; set; }
        public DataTable data_table { get; set; }

        public bool gui_mode = true;
        public bool check_id = false;
        public string user_profile; // = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public string default_save_path;
        public string save_name;
        public string load_name;
        public string date_str;     //Today's date as a string
        public int current_selection;    //The ID of the currently selected row


//=======================================================================================================================
//------------------------------------------------------Constructor------------------------------------------------------
//=======================================================================================================================

        public Manager()
        {
            
            monster_list = new List<Monster>();
            data_table = new DataTable();
            //Setup options
            user_profile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            //default_save_path = user_profile + "\\Documents\\Monster Manager\\";

            default_save_path = "Documents\\Monster Database\\";

            //importOptions();    //Reads the options.txt file
            //importXML();    //Imports the auto_save.xml

            //SetupData();

            data_table.Columns.Add("Name");
            data_table.Columns.Add("Type");
            data_table.Columns.Add("SubType");
            data_table.Columns.Add("Territory");
            data_table.Columns.Add("ChallengeRating");
            data_table.Columns.Add("Alignment");
            data_table.Columns.Add("ArmorClass");
            data_table.Columns.Add("HealthPoints");
            data_table.Columns.Add("Size");
            data_table.Columns.Add("PageNumber");
            data_table.Columns.Add("SourceBook");
            data_table.Columns.Add("Notes");
            data_table.Columns.Add("ID");
            

        }
        
//=======================================================================================================================
//-----------------------------------------------------------------------------------------------------------------------
//=======================================================================================================================

        public void importOptions()    //Reads the options.txt saved in the Documents folder
        {

            //string[] options = File.ReadAllLines(user_profile + "\\Documents\\Monster Database\\options.txt");

            string[] options = File.ReadAllLines("Documents\\Monster Database\\options.txt");

            foreach (string str in options)
            {
                string[] opt = str.Split(':');
                switch (opt[0])
                {
                    case "save_name":
                        {
                            save_name = opt[1];
                            break;
                        }
                    case "load_name":
                        {
                            load_name = opt[1];
                            break;
                        }
                    case "date_format":
                        {
                            if (opt[1] == "dd/mm/yyyy")
                            {
                                date_str = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();
                            }
                            else if (opt[1] == "mm/dd/yyyy")
                            {
                                date_str = DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString() + "-" + DateTime.Today.Year.ToString();
                            }
                            else
                            {
                                date_str = "No Format Given";
                            }

                            break;
                        }

                    case "gui":
                        {
                            if (opt[1].ToLower() == "true") gui_mode = true;
                            else gui_mode = false;
                            break;
                        }
                    case "check_id":
                        {
                            if (opt[1] == "true") check_id = true;
                            else check_id = false;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }

//=======================================================================================================================
//-----------------------------------------------------------------------------------------------------------------------
//=======================================================================================================================

        public void importXML()
        {
            //Console.Write("File name: ");
            string filename = default_save_path + load_name + ".xml";
            if (File.Exists(filename))
            {
                XmlSerializer serial = new XmlSerializer(typeof(List<Monster>));
                FileStream reader = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
                monster_list = (List<Monster>)serial.Deserialize(reader);

                reader.Close();

            }

            getUniqueId();
            if (check_id)
            {
                checkID();
            }
                
            
        }

//=======================================================================================================================
//-----------------------------------------------------------------------------------------------------------------------
//=======================================================================================================================

        public void saveXML(List<Monster> obj, string filename)
        {
            XmlSerializer serial = new XmlSerializer(obj.GetType());

            StreamWriter writer = new StreamWriter(filename);
            serial.Serialize(writer, obj);
            writer.Close();
        }

//=======================================================================================================================
//-----------------------------------------------------------------------------------------------------------------------
//=======================================================================================================================

        public void saveBackup()
        {
            int ct = 1;
            if (File.Exists(default_save_path + "Backups\\backup_save_" + date_str + ".xml"))
            {
                while (File.Exists(default_save_path + "Backups\\backup_save_" + date_str + " (" + ct + ").xml"))
                {
                    ct++;
                }
                saveXML(monster_list, default_save_path + "Backups\\backup_save_" + date_str + " (" + ct + ").xml");
            }
            else
            {
                saveXML(monster_list, default_save_path + "Backups\\backup_save_" + date_str + ".xml");
            }

        }

//=======================================================================================================================
//-----------------------------------------------------------------------------------------------------------------------
//=======================================================================================================================

        private void SetupData()    //Test Data
        {
            monster_list.Add(new Monster { Name = "Monster 1" });
            monster_list.Add(new Monster { Name = "Monster 2" });
            monster_list.Add(new Monster { Name = "Monster 3" });
            

            //XML Save
            saveXML(monster_list, default_save_path + "auto_save.xml");
            saveBackup();

        }


//=======================================================================================================================
//-----------------------------------------------------------------------------------------------------------------------
//=======================================================================================================================

        public int getNewID()
        {
            int t_int = unique_id;
            unique_id++;
            return t_int;
        }


//=======================================================================================================================
//-----------------------------------------------------------------------------------------------------------------------
//=======================================================================================================================

        private void checkID()
        {
            foreach (Monster m in monster_list)
            {
               if(m.ID == -1)
                {
                    m.ID = getNewID();
                }
            }
                 
        }

//=======================================================================================================================
//-----------------------------------------------------------------------------------------------------------------------
//=======================================================================================================================

        private void getUniqueId()
        {
            //Get the last id value
            unique_id = monster_list[0].ID;
            foreach (Monster m in monster_list)
            {
                if (unique_id < m.ID)
                {
                    unique_id = m.ID;
                }
            }
            unique_id++;    //Next valid id
        }


    }
}
