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
    public partial class CommentAdd : Form
    {
        private readonly IRepository _repository;
        public CommentAdd(int lawyerId, int documentId)
        {
            _repository = RepositoryFactory.Create();
            InitializeComponent();
            DocumentIdHid.Text = documentId.ToString();
            LawyerIdHid.Text = lawyerId.ToString();
        }

        private void CommentAddBtn_Click(object sender, EventArgs e)
        {
            int lawyerId = int.Parse(LawyerIdHid.Text);
            int documentId = int.Parse(DocumentIdHid.Text);
            var comment = new Comment
            {
                DocumentId = documentId,
                LawyerId = lawyerId,
                Description = CommentDesc.Text,
                Date = DateTime.Now
            };

            _repository.Of<Comment>().Insert(comment);
            _repository.SaveChanges();
            MessageBox.Show("Comment successfull added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
