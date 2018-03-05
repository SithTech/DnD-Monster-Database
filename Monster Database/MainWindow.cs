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
    public partial class MainWindow : Form
    {
        public Manager mgr = new Manager();

        public MainWindow()
        {
            InitializeComponent();

            mgr.importOptions();
            mgr.importXML();

            showAll();
        }

//=======================================================================================================================
//-----------------------------------------------------------------------------------------------------------------------
//=======================================================================================================================

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            
            //searchGridView.Rows.Clear();
            mgr.data_table.Rows.Clear();

            string find_str = searchTextBox.Text;
            //searchTextBox.Clear();

            bool isMatch = false;

            if (find_str != "")
            {
                foreach (Monster m in mgr.monster_list)
                {
                    isMatch = false;

                    if (checkBox_Name.Checked)
                    {
                        if (m.Name.ToLower().Contains(find_str.ToLower()))
                        {
                            //mgr.data_table.Rows.Add(m.Name, m.Type, m.SubType, m.Territory, m.ChallengeRating, m.Alignment, m.ArmorClass, m.HealthPoints, m.ExperiencePoints, m.Size, m.PageNumber, m.SourceBook, m.Notes);
                            isMatch = true;
                        }
                    }
                    if (checkBox_Type.Checked)
                    {
                        if (m.Type.ToLower().Contains(find_str.ToLower()))
                        {
                            //mgr.data_table.Rows.Add(m.Name, m.Type, m.SubType, m.Territory, m.ChallengeRating, m.Alignment, m.ArmorClass, m.HealthPoints, m.ExperiencePoints, m.Size, m.PageNumber, m.SourceBook, m.Notes);
                            isMatch = true;
                        }
                    }
                    if (checkBox_SubType.Checked)
                    {
                        if (m.SubType.ToLower().Contains(find_str.ToLower()))
                        {
                            //mgr.data_table.Rows.Add(m.Name, m.Type, m.SubType, m.Territory, m.ChallengeRating, m.Alignment, m.ArmorClass, m.HealthPoints, m.ExperiencePoints, m.Size, m.PageNumber, m.SourceBook, m.Notes);
                            isMatch = true;
                        }
                    }
                    if (checkBox_Territory.Checked)
                    {
                        if (m.Territory.ToLower().Contains(find_str.ToLower()))
                        {
                            //mgr.data_table.Rows.Add(m.Name, m.Type, m.SubType, m.Territory, m.ChallengeRating, m.Alignment, m.ArmorClass, m.HealthPoints, m.ExperiencePoints, m.Size, m.PageNumber, m.SourceBook, m.Notes);
                            isMatch = true;
                        }
                    }
                    if (checkBox_ChallengeRating.Checked)
                    {
                        if (m.ChallengeRating.ToLower().Contains(find_str.ToLower()))
                        {
                            //mgr.data_table.Rows.Add(m.Name, m.Type, m.SubType, m.Territory, m.ChallengeRating, m.Alignment, m.ArmorClass, m.HealthPoints, m.ExperiencePoints, m.Size, m.PageNumber, m.SourceBook, m.Notes);
                            isMatch = true;
                        }
                    }
                    if (checkBox_Alignment.Checked)
                    {
                        if (m.Alignment.ToLower().Contains(find_str.ToLower()))
                        {
                            //mgr.data_table.Rows.Add(m.Name, m.Type, m.SubType, m.Territory, m.ChallengeRating, m.Alignment, m.ArmorClass, m.HealthPoints, m.ExperiencePoints, m.Size, m.PageNumber, m.SourceBook, m.Notes);
                            isMatch = true;
                        }
                    }
                    if (checkBox_ArmorClass.Checked)
                    {
                        if (m.ArmorClass.ToLower().Contains(find_str.ToLower()))
                        {
                            //mgr.data_table.Rows.Add(m.Name, m.Type, m.SubType, m.Territory, m.ChallengeRating, m.Alignment, m.ArmorClass, m.HealthPoints, m.ExperiencePoints, m.Size, m.PageNumber, m.SourceBook, m.Notes);
                            isMatch = true;
                        }
                    }
                    if (checkBox_HealthPoints.Checked)
                    {
                        if (m.HealthPoints.ToLower().Contains(find_str.ToLower()))
                        {
                            //mgr.data_table.Rows.Add(m.Name, m.Type, m.SubType, m.Territory, m.ChallengeRating, m.Alignment, m.ArmorClass, m.HealthPoints, m.ExperiencePoints, m.Size, m.PageNumber, m.SourceBook, m.Notes);
                            isMatch = true;
                        }
                    }
                    
                    if (checkBox_Size.Checked)
                    {
                        if (m.Size.ToLower().Contains(find_str.ToLower()))
                        {
                            //mgr.data_table.Rows.Add(m.Name, m.Type, m.SubType, m.Territory, m.ChallengeRating, m.Alignment, m.ArmorClass, m.HealthPoints, m.ExperiencePoints, m.Size, m.PageNumber, m.SourceBook, m.Notes);
                            isMatch = true;
                        }
                    }
                    if (checkBox_PageNumber.Checked)
                    {
                        if (m.PageNumber.ToLower().Contains(find_str.ToLower()))
                        {
                            //mgr.data_table.Rows.Add(m.Name, m.Type, m.SubType, m.Territory, m.ChallengeRating, m.Alignment, m.ArmorClass, m.HealthPoints, m.ExperiencePoints, m.Size, m.PageNumber, m.SourceBook, m.Notes);
                            isMatch = true;
                        }
                    }
                    if (checkBox_SourceBook.Checked)
                    {
                        if (m.SourceBook.ToLower().Contains(find_str.ToLower()))
                        {
                            //mgr.data_table.Rows.Add(m.Name, m.Type, m.SubType, m.Territory, m.ChallengeRating, m.Alignment, m.ArmorClass, m.HealthPoints, m.ExperiencePoints, m.Size, m.PageNumber, m.SourceBook, m.Notes);
                            isMatch = true;
                        }
                    }
                    if (checkBox_Notes.Checked)
                    {
                        if (m.Notes.ToLower().Contains(find_str.ToLower()))
                        {
                            //mgr.data_table.Rows.Add(m.Name, m.Type, m.SubType, m.Territory, m.ChallengeRating, m.Alignment, m.ArmorClass, m.HealthPoints, m.ExperiencePoints, m.Size, m.PageNumber, m.SourceBook, m.Notes);
                            isMatch = true;
                        }
                    }

                    if (isMatch)
                    {
                        mgr.data_table.Rows.Add(m.Name, m.Type, m.SubType, m.Territory, m.ChallengeRating, m.Alignment, m.ArmorClass, m.HealthPoints, m.Size, m.PageNumber, m.SourceBook, m.Notes, m.ID);

                    }

                }
                searchGridView.DataSource = mgr.data_table;
            }
            else
            {
                showAll();
            }
        }

        private void showAll()
        {
            mgr.data_table.Rows.Clear();
            foreach (Monster m in mgr.monster_list)
            {
                mgr.data_table.Rows.Add(m.Name, m.Type, m.SubType, m.Territory, m.ChallengeRating, m.Alignment, m.ArmorClass, m.HealthPoints, m.Size, m.PageNumber, m.SourceBook, m.Notes, m.ID);
            }
            searchGridView.DataSource = mgr.data_table;
            //searchGridView.DataSource = mgr.monster_list;
            
        }

        private void UpdateList(int index)
        {
            mgr.data_table.Rows.Clear();
            foreach (Monster m in mgr.monster_list)
            {
                mgr.data_table.Rows.Add(m.Name, m.Type, m.SubType, m.Territory, m.ChallengeRating, m.Alignment, m.ArmorClass, m.HealthPoints, m.Size, m.PageNumber, m.SourceBook, m.Notes, m.ID);
            }
            searchGridView.DataSource = mgr.data_table;
            searchGridView[0, index].Selected = true;
            //searchGridView.DataSource = mgr.monster_list;

        }

        private void searchGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int t_index = mgr.monster_list.FindIndex(x => x.ID.Equals(Convert.ToInt32(searchGridView.SelectedRows[0].Cells[12].Value)));
            mgr.current_selection = t_index;
            
            EditWindow edit_window = new EditWindow(mgr, t_index, "edit");
            edit_window.ShowDialog();

            /*
            if(edit_window.edit_monster != null)
            {
                searchGridView.CurrentRow.SetValues(edit_window.edit_monster.Name, edit_window.edit_monster.Type, edit_window.edit_monster.SubType, edit_window.edit_monster.Territory, edit_window.edit_monster.ChallengeRating, edit_window.edit_monster.Alignment, edit_window.edit_monster.ArmorClass, edit_window.edit_monster.HealthPoints, edit_window.edit_monster.Size, edit_window.edit_monster.PageNumber, edit_window.edit_monster.SourceBook, edit_window.edit_monster.Notes, edit_window.edit_monster.ID);
            }
            */

            mgr = edit_window.updated_mgr;
            searchGridView.DataSource = mgr.data_table;
            UpdateList(t_index);


            //showAll();
            //searchGridView.InvalidateRow(searchGridView.SelectedRows[0].Index);
            //searchGridView.Refresh();
            //searchGridView.Update();
            
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            showAll();
        }

        private void btn_newMonster_Click(object sender, EventArgs e)
        {
            int t_index = mgr.monster_list.FindIndex(x => x.ID.Equals(Convert.ToInt32(searchGridView.SelectedRows[0].Cells[12].Value)));
            EditWindow edit_window = new EditWindow(mgr, t_index, "new");
            edit_window.ShowDialog();

            mgr = edit_window.updated_mgr;
            searchGridView.DataSource = mgr.data_table;
            UpdateList(searchGridView.RowCount);

            //showAll();
            //searchGridView.Refresh();
            //searchGridView.Update();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (searchGridView.SelectedCells.Count == 0) MessageBox.Show("No enrtries have been selected.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (MessageBox.Show("Are you sure you want to delete this entry?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int t_index = mgr.monster_list.FindIndex(x => x.ID.Equals(Convert.ToInt32(searchGridView.SelectedRows[0].Cells[12].Value)));
                mgr.monster_list.Remove(mgr.monster_list.Find(x => x.ID.Equals(Convert.ToInt32(searchGridView.SelectedRows[0].Cells[12].Value))));
                UpdateList(t_index - 1);    
            }       
        }

        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            mgr.data_table.Rows.Clear();
            searchTextBox.Clear();

            if (checkBox_Name.Checked)
            {
                checkBox_Name.Checked = false;
            }
            if (checkBox_Type.Checked)
            {
                checkBox_Type.Checked = false;
            }
            if (checkBox_SubType.Checked)
            {
                checkBox_SubType.Checked = false;
            }
            if (checkBox_Territory.Checked)
            {
                checkBox_Territory.Checked = false;
            }
            if (checkBox_ChallengeRating.Checked)
            {
                checkBox_ChallengeRating.Checked = false;
            }
            if (checkBox_Alignment.Checked)
            {
                checkBox_Alignment.Checked = false;
            }
            if (checkBox_ArmorClass.Checked)
            {
                checkBox_ArmorClass.Checked = false;
            }
            if (checkBox_HealthPoints.Checked)
            {
                checkBox_HealthPoints.Checked = false;
            }
            
            if (checkBox_Size.Checked)
            {
                checkBox_Size.Checked = false;
            }
            if (checkBox_PageNumber.Checked)
            {
                checkBox_PageNumber.Checked = false;
            }
            if (checkBox_SourceBook.Checked)
            {
                checkBox_SourceBook.Checked = false;
            }
            if (checkBox_Notes.Checked)
            {
                checkBox_Notes.Checked = false;
            }


        }

        private void btn_CheckAll_Click(object sender, EventArgs e)
        {
            checkBox_Name.Checked = true;
            checkBox_Type.Checked = true;
            checkBox_SubType.Checked = true;
            checkBox_Territory.Checked = true;
            checkBox_ChallengeRating.Checked = true;
            checkBox_Alignment.Checked = true;
            checkBox_ArmorClass.Checked = true;
            checkBox_HealthPoints.Checked = true;
            
            checkBox_Size.Checked = true;
            checkBox_PageNumber.Checked = true;
            checkBox_SourceBook.Checked = true;
            checkBox_Notes.Checked = true;
        }

        private void searchGridView_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyCode == Keys.Enter)
            {
                mgr.monster_list.Add(new Monster
                {
                    Name = searchGridView.CurrentRow.Cells[0].Value.ToString(),
                    Type = searchGridView.CurrentRow.Cells[1].Value.ToString(),
                    SubType = searchGridView.CurrentRow.Cells[2].Value.ToString(),
                    Territory = searchGridView.CurrentRow.Cells[3].Value.ToString(),
                    ChallengeRating = searchGridView.CurrentRow.Cells[4].Value.ToString(),
                    Alignment = searchGridView.CurrentRow.Cells[5].Value.ToString(),
                    ArmorClass = searchGridView.CurrentRow.Cells[6].Value.ToString(),
                    HealthPoints = searchGridView.CurrentRow.Cells[7].Value.ToString(),
                    Size = searchGridView.CurrentRow.Cells[8].Value.ToString(),
                    PageNumber = searchGridView.CurrentRow.Cells[9].Value.ToString(),
                    SourceBook = searchGridView.CurrentRow.Cells[10].Value.ToString(),
                    Notes = searchGridView.CurrentRow.Cells[11].Value.ToString(),
                    ID = mgr.getNewID()
                });
            }
            //*/
            if (e.KeyCode == Keys.Delete)
            {
                if (searchGridView.SelectedCells.Count == 0) MessageBox.Show("No enrtries have been selected.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (MessageBox.Show("Are you sure you want to delete this entry?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int t_index = mgr.monster_list.FindIndex(x => x.ID.Equals(Convert.ToInt32(searchGridView.SelectedRows[0].Cells[12].Value)));
                    mgr.monster_list.Remove(mgr.monster_list.Find(x => x.ID.Equals(Convert.ToInt32(searchGridView.SelectedRows[0].Cells[12].Value))));
                    UpdateList(t_index - 1);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mgr.saveXML(mgr.monster_list, mgr.default_save_path + mgr.save_name + ".xml");
            mgr.saveBackup();
        }

        //=======================================================================================================================
        //-----------------------------------------------------------------------------------------------------------------------
        //=======================================================================================================================

    }
}
