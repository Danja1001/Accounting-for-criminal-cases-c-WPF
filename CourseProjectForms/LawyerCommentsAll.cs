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
    public partial class LawyerCommentsAll : Form
    {
        private readonly IRepository _repository;
        public LawyerCommentsAll(int lawyerId, int documentId, int caseId)
        {
            _repository = RepositoryFactory.Create();
            InitializeComponent();
            Load += LawyerCommentsAll_Load;
            var comments = _repository.Of<Comment>().
                Search(x => x.DocumentId == documentId)
                .ToArray();
            var @case = _repository.Of<Case>()
                .GetById(caseId);
            var document = _repository.Of<Document>()
                .GetById(documentId);

            CaseTitleLbl.Text = @case.Title;
            CaseDescription.Text = @case.Description;
            DocumentBox.Image = Bitmap.FromFile(document.PathToImage);

            if (comments.Count() > 0)
            {
                CommentsGrid.Visible = true;

                foreach (var comment in comments)
                {
                    var lawyer = _repository.Of<Lawyer>()
                        .GetById(comment.LawyerId);
                    CommentsGrid.Rows.Add(comment.Id, lawyer.FirstName, comment.Description);
                }
            } else
            {
                CommentsLbl.Visible = true;
            }
        }

        private void LawyerCommentsAll_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}
