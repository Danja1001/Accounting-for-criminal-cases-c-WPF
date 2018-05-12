using System;
using System.Configuration;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using CourseProjectForms.DB;
using CourseProjectForms.DB.Interfaces;
using CourseProjectForms.DomainModel;
using CourseProjectForms.Extensions;

namespace CourseProjectForms
{
    public partial class AdminViewForm : Form
    {
        private readonly IRepository _repository;
        public AdminViewForm()
        {
            _repository = RepositoryFactory.Create();
            InitializeComponent();
            Load += AdminViewForm_Load;
        }

        private void AdminViewForm_Load(object sender, EventArgs e)
        {
            var lawyers = _repository.Of<Lawyer>().GetAll().ToArray();

            //SELECT Id FROM Lawyer

            foreach (var lawyer in lawyers)
            {
                LawyersGrid.Rows.Add(lawyer.Id, lawyer.FirstName, lawyer.LastName, lawyer.Email, lawyer.DateOfBirth);
            }
        }

        private void AddNewLawyerBtn_Click(object sender, EventArgs e)
        {
            Hide();
            OnClickAdd onClickAdd = new OnClickAdd();
            onClickAdd.ShowDialog();
        }

        private void LawyerEditorBtn_Click(object sender, EventArgs e)
        {
            AdminViewForm adminViewForm = new AdminViewForm();
            adminViewForm.ShowDialog();
        }

        private void CasesEditorBtn_Click(object sender, EventArgs e)
        {
            Hide();
            CaseEditor caseEditor = new CaseEditor();
            caseEditor.ShowDialog();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //((System.Windows.Forms.DataGridViewTextBoxCell)LawyersGrid.Rows[e.RowIndex].Cells[0]).ValueType
            if(e.ColumnIndex == 5)
            {
                //EDIT
                if (e.RowIndex < 0)
                {
                    MessageBox.Show("This column is a button.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                Hide();
                var lawyerId = (int)LawyersGrid.Rows[e.RowIndex].Cells[0].Value;

                EditLawyer editLawyer = new EditLawyer(lawyerId);
                editLawyer.ShowDialog();

            }
        }

        private void LawyerBusy_Click(object sender, EventArgs e)
        {
            var lawyers = _repository.Of<Lawyer>()
                .Search(x => x.Cases.Any(y => y.EndDate != null))
                .ToArray();
            //SELECT LawyerId FROM LawyerToCase WHERE LawyerId > 0;

            LawyersGrid.Rows.Clear();
            foreach (var lawyer in lawyers)
            {
                LawyersGrid.Rows.Add(lawyer.Id, lawyer.FirstName, lawyer.LastName, lawyer.Email, lawyer.DateOfBirth);
            }
        }

        private void LawyerFree_Click(object sender, EventArgs e)
        {
            var lawyers = _repository.Of<Lawyer>()
                .Search(x => x.Cases.Any(y => y.EndDate == null))
                .ToArray();
            
            LawyersGrid.Rows.Clear();

            foreach (var lawyer in lawyers)
            {
                LawyersGrid.Rows.Add(lawyer.Id, lawyer.FirstName, lawyer.LastName, lawyer.Email, lawyer.DateOfBirth);
            }
        }
    }
}
