using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonsterDatabaseLibrary;

namespace Monster_Database
{
    public partial class EditWindow : Form
    {
        public Manager updated_mgr = new Manager();

        public Monster new_monster;
        public Monster edit_monster;

        public int index;
        public string mode;
        public int current_id;

        public EditWindow(Manager mgr, int i, string md)
        {
            updated_mgr = mgr;
            index = i;
            mode = md;

            InitializeComponent();

            if (mode.Equals("edit"))
            {
                textBox_Name.Text = mgr.monster_list[index].Name;
                textBox_Type.Text = mgr.monster_list[index].Type;
                textBox_SubType.Text = mgr.monster_list[index].SubType;
                textBox_Territory.Text = mgr.monster_list[index].Territory;
                textBox_ChallengeRating.Text = mgr.monster_list[index].ChallengeRating;
                textBox_Alignment.Text = mgr.monster_list[index].Alignment;
                textBox_ArmorClass.Text = mgr.monster_list[index].ArmorClass;
                textBox_HealthPoints.Text = mgr.monster_list[index].HealthPoints;
                
                textBox_Size.Text = mgr.monster_list[index].Size;
                textBox_PageNumber.Text = mgr.monster_list[index].PageNumber;
                textBox_SourceBook.Text = mgr.monster_list[index].SourceBook;
                textBox_Notes.Text = mgr.monster_list[index].Notes;
                current_id = mgr.monster_list[index].ID;

                //edit_monster = new Monster { Name = textBox_Name.Text, Type = textBox_Type.Text, SubType = textBox_SubType.Text, Territory = textBox_Territory.Text, ChallengeRating = textBox_ChallengeRating.Text, Alignment = textBox_Alignment.Text, ArmorClass = textBox_ArmorClass.Text, HealthPoints = textBox_HealthPoints.Text, Size = textBox_Size.Text, PageNumber = textBox_PageNumber.Text, SourceBook = textBox_SourceBook.Text, Notes = textBox_Notes.Text, ID = current_id };

            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Monster new_monster = new Monster { Name = textBox_Name.Text, Type = textBox_Type.Text, SubType = textBox_SubType.Text, Territory = textBox_Territory.Text, ChallengeRating = textBox_ChallengeRating.Text, Alignment = textBox_Alignment.Text, ArmorClass = textBox_ArmorClass.Text, HealthPoints = textBox_HealthPoints.Text, Size = textBox_Size.Text, PageNumber = textBox_PageNumber.Text, SourceBook = textBox_SourceBook.Text, Notes = textBox_Notes.Text, ID = current_id};
            switch (mode)
            {
                case "edit":
                    {
                        updated_mgr.monster_list[index] = new_monster;
                        //edit_monster = new Monster { Name = textBox_Name.Text, Type = textBox_Type.Text, SubType = textBox_SubType.Text, Territory = textBox_Territory.Text, ChallengeRating = textBox_ChallengeRating.Text, Alignment = textBox_Alignment.Text, ArmorClass = textBox_ArmorClass.Text, HealthPoints = textBox_HealthPoints.Text, Size = textBox_Size.Text, PageNumber = textBox_PageNumber.Text, SourceBook = textBox_SourceBook.Text, Notes = textBox_Notes.Text, ID = current_id };
                        break;
                    }
                case "new":
                    {
                        new_monster.ID = updated_mgr.getNewID();
                        updated_mgr.monster_list.Add(new_monster);
                        //new_monster = new Monster { Name = textBox_Name.Text, Type = textBox_Type.Text, SubType = textBox_SubType.Text, Territory = textBox_Territory.Text, ChallengeRating = textBox_ChallengeRating.Text, Alignment = textBox_Alignment.Text, ArmorClass = textBox_ArmorClass.Text, HealthPoints = textBox_HealthPoints.Text, Size = textBox_Size.Text, PageNumber = textBox_PageNumber.Text, SourceBook = textBox_SourceBook.Text, Notes = textBox_Notes.Text, ID = current_id };
                        break;
                    }
            }
            this.Close();

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
