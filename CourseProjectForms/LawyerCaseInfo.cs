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
    public partial class LawyerCaseInfo : Form
    {
        private readonly IRepository _repository;
        public LawyerCaseInfo(int caseId, int lawyerId)
        {
            _repository = RepositoryFactory.Create();
            InitializeComponent();
            Load += LawyerCaseInfo_Load;

            LawyerId.Text = lawyerId.ToString();

            var @case = _repository.Of<Case>()
                .Search(x => x.Id == caseId)
                .FirstOrDefault();

            CaseTitleLbl.Text = @case.Title;
            CaseDescTxt.Text = @case.Description;
            CaseId.Text = caseId.ToString();

            var documents = _repository.Of<Document>()
                .Search(x => x.CaseId == caseId)
                .ToArray();
            if (documents.Count() > 0)
            {
                DocumentGrid.Visible = true;
                DocumentGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                foreach (var document in documents)
                {

                    DocumentGrid.Rows.Add(document.Id, Bitmap.FromFile(document.PathToImage));
                }
            }
            else
            {
                NoEvidence.Visible = true;
            }
        }

        private void LawyerCaseInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void CaseFinish_Click(object sender, EventArgs e)
        {
            int lawyerId = int.Parse(LawyerId.Text);
            var @case = _repository.Of<Case>()
                .Search(x => x.Lawyers.Any(y => y.Id == lawyerId))
                .FirstOrDefault();

            @case.EndDate = DateTime.Now;
            _repository.SaveChanges();
            MessageBox.Show("Case successfull finished!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void LawyerCaseInfo_Load_1(object sender, EventArgs e)
        {

        }

        private void CommentAdd_Click(object sender, EventArgs e)
        {
            evidenceFileDialog.ShowDialog();
            if (evidenceFileDialog.ShowDialog() == DialogResult.OK)
            {
                var pathUploadImage = evidenceFileDialog.FileName;
                var pathOfMovement = "D:\\CourseProjectForms_v3\\CourseProjectForms_v3\\CourseProjectForms\\CourseProjectForms\\_evidences\\" + evidenceFileDialog.SafeFileName;
                int caseId = int.Parse(CaseId.Text);
                var evidence = new Document
                {
                    CaseId = caseId,
                    PathToImage = pathOfMovement,
                    Date = DateTime.Now
                };

                _repository.Of<Document>().Insert(evidence);
                _repository.SaveChanges();

                File.Copy(pathUploadImage, pathOfMovement);
                MessageBox.Show("Evidence successfull add!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
