using System;
using System.IO;
using System.Drawing;
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
    public partial class CaseInfo : Form
    {
        private readonly IRepository _repository;
        public CaseInfo(DomainModel.Lawyer lawyer, DomainModel.Case @case)
        {
            _repository = RepositoryFactory.Create();
            InitializeComponent();
            Load += CaseInfo_Load;

            var lawyerCase = _repository.Of<Lawyer>()
                .Search(x => x.Cases.Any(y => y.Id == @case.Id))
                .ToArray();

            CaseTitleLbl.Text = @case.Title;
            CaseDescTxt.Text = @case.Description;
            LawyerId.Text = lawyer.Id.ToString();
            CaseId.Text = @case.Id.ToString();

            if(lawyerCase.Count() > 0 )
            {
                foreach (var lawyers in lawyerCase)
                {
                    LawyersList.Items.Add(lawyers.FirstName);
                }
            } else
            {
                LawyersList.Visible = false;
                LawyerEmpty.Visible = true;
            }

            var documents = _repository.Of<Document>()
                .Search(x => x.CaseId == @case.Id)
                .ToArray();
            if(documents.Count() > 0)
            {
                DocumentGrid.Visible = true;
                DocumentGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                foreach (var document in documents)
                {

                    DocumentGrid.Rows.Add(document.Id, Bitmap.FromFile(document.PathToImage));
                }
            } else
            {
                NoEvidence.Visible = true;
            }
           
        }

        private void CaseInfo_Load(object sender, EventArgs e)
        {

        }

        private void CaseInfo_Load_1(object sender, EventArgs e)
        {

        }

        private void CommentAdd_Click(object sender, EventArgs e)
        {

        }

        private void DocumentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2 || e.ColumnIndex == 3)
            {
                if (e.RowIndex < 0)
                {
                    MessageBox.Show("This column is a button.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int lawyerId = int.Parse(LawyerId.Text);
                var DocumentId = (int)DocumentGrid.Rows[e.RowIndex].Cells[0].Value;

                if (e.ColumnIndex == 3)
                {
                    int caseId = int.Parse(CaseId.Text);
                    LawyerCommentsAll lawyerCommentsAll = new LawyerCommentsAll(lawyerId, DocumentId,caseId);
                    lawyerCommentsAll.ShowDialog();
                    return;
                }

                CommentAdd commentAdd = new CommentAdd(lawyerId, DocumentId);
                commentAdd.ShowDialog();
            }
        }
    }
}
