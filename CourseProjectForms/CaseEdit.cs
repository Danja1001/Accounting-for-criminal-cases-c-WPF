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
    public partial class CaseEdit : Form
    {
        private readonly IRepository _repository;
        public CaseEdit(int caseId)
        {
            _repository = RepositoryFactory.Create();
            InitializeComponent();
            Load += CaseEdit_Load;

            var @case = _repository.Of<Case>().GetById(caseId);
            caseIdTxt.Text = @case.Id.ToString();
            CaseTitleTxt.Text = @case.Title;
            CaseDescriptionTxt.Text = @case.Description;
            CaseStartPicker.Value = @case.StartDate;
            //CaseEndPicker.Value = @case.EndDate;
            
        }

        private void CaseEdit_Load(object sender, EventArgs e)
        {
            
        }

        private void CaseEditBtn_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(caseIdTxt.Text);

            var @case = _repository.Of<Case>()
                .Search(x => x.Id == Id).FirstOrDefault();

            if(@case != null)
            {
                @case.Title = CaseTitleTxt.Text;
                @case.Description = CaseDescriptionTxt.Text;
                @case.StartDate = CaseStartPicker.Value;

                _repository.SaveChanges();

                MessageBox.Show("The case was successfully edited.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Hide();
                CaseEditor caseEditor = new CaseEditor();
                caseEditor.ShowDialog();
            } else
            {
                MessageBox.Show("Could not edit this case.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void BackCase_Click(object sender, EventArgs e)
        {
            Hide();
            CaseEditor caseEditor = new CaseEditor();
            caseEditor.ShowDialog();
        }

        private void CaseDelete_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(caseIdTxt.Text);
            var @case = _repository.Of<Case>().GetById(Id);

            var lawyers = _repository.Of<Lawyer>()
                .Search(x => x.Cases.Any(y => y.Id == Id))
                .Count();

            if(lawyers > 0)
            {
                MessageBox.Show("Case busy", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _repository.Of<Case>().Delete(@case);
            _repository.SaveChanges();

            MessageBox.Show("The case was successfully deleted.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Hide();
            CaseEditor caseEditor = new CaseEditor();
            caseEditor.ShowDialog();
        }
    }
}
