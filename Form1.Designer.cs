using System.Drawing;
using System.Windows.Forms;

namespace PP2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer? components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            toolbar = new Panel();
            recordIDLabel = new Label();
            txtRecordID = new TextBox();
            searchLabel = new Label();
            cmbSearchBy = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnNew = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            btnLogin = new Button();
            btnRegister = new Button();
            btnLogout = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            page1 = new Panel();
            tabPage2 = new TabPage();
            page2 = new Panel();
            tabPage3 = new TabPage();
            page3 = new Panel();
            tabPage4 = new TabPage();
            page4 = new Panel();
            tabPage5 = new TabPage();
            page5 = new Panel();
            osaLabel = new Label();
            txtOSA = new TextBox();
            university = new Label();
            address = new Label();
            policyTitle = new Label();
            caseTitle = new Label();
            printNote = new Label();
            stepOne = new Label();
            facultyInstructions = new Label();
            txtStudentNameLabel = new Label();
            txtStudentName = new TextBox();
            txtStudentIDLabel = new Label();
            txtStudentID = new TextBox();
            txtStudentEmailLabel = new Label();
            txtStudentEmail = new TextBox();
            txtFacultyNameLabel = new Label();
            txtFacultyName = new TextBox();
            txtCaseDateLabel = new Label();
            txtCaseDate = new TextBox();
            txtCourseNameLabel = new Label();
            txtCourseName = new TextBox();
            txtCourseNumberLabel = new Label();
            txtCourseNumber = new TextBox();
            txtAssignmentLabel = new Label();
            txtAssignment = new TextBox();
            txtDepartmentLabel = new Label();
            txtDepartment = new TextBox();
            txtTermIDLabel = new Label();
            txtTermID = new TextBox();
            txtViolationLabel = new Label();
            txtViolation = new TextBox();
            sanctionGuidance = new Label();
            txtSanctionsLabel = new Label();
            txtSanctions = new TextBox();
            chkSupportPerson = new CheckBox();
            chkWrittenStatement = new CheckBox();
            txtInitialFacultySignatureLabel = new Label();
            txtInitialFacultySignature = new TextBox();
            txtInitialFacultyNameLabel = new Label();
            txtInitialFacultyName = new TextBox();
            txtInitialFacultyDateLabel = new Label();
            txtInitialFacultyDate = new TextBox();
            page1FormCode = new Label();
            page1Footer = new Label();
            stepTwo = new Label();
            studentInstructions = new Label();
            txtAcknowledgedStudentLabel = new Label();
            txtAcknowledgedStudent = new TextBox();
            acknowledgmentText = new Label();
            grpStudentReview = new Panel();
            grpStudentReviewQuestion = new Label();
            grpStudentReviewYes = new RadioButton();
            grpStudentReviewNo = new RadioButton();
            studentCommentsNote = new Label();
            txtMyTRUEmailLabel = new Label();
            txtMyTRUEmail = new TextBox();
            txtStudentSignatureLabel = new Label();
            txtStudentSignature = new TextBox();
            txtStudentDateLabel = new Label();
            txtStudentDate = new TextBox();
            emailNote = new Label();
            stepThree = new Label();
            facultyFollowup = new Label();
            txtFollowupFacultySignatureLabel = new Label();
            txtFollowupFacultySignature = new TextBox();
            txtFollowupFacultyNameLabel = new Label();
            txtFollowupFacultyName = new TextBox();
            txtFollowupFacultyDateLabel = new Label();
            txtFollowupFacultyDate = new TextBox();
            page2FormCode = new Label();
            page2Footer = new Label();
            stepFour = new Label();
            chairInstructions = new Label();
            grpChairAgreement = new Panel();
            grpChairAgreementQuestion = new Label();
            grpChairAgreementYes = new RadioButton();
            grpChairAgreementNo = new RadioButton();
            txtChairExplanationLabel = new Label();
            txtChairExplanation = new TextBox();
            txtChairCommentsLabel = new Label();
            txtChairComments = new TextBox();
            txtChairSignatureLabel = new Label();
            txtChairSignature = new TextBox();
            txtChairNameLabel = new Label();
            txtChairName = new TextBox();
            txtChairDateLabel = new Label();
            txtChairDate = new TextBox();
            stepFive = new Label();
            deanInstructions = new Label();
            grpDeanAgreement = new Panel();
            grpDeanAgreementQuestion = new Label();
            grpDeanAgreementYes = new RadioButton();
            grpDeanAgreementNo = new RadioButton();
            txtDeanExplanationLabel = new Label();
            txtDeanExplanation = new TextBox();
            txtDeanCommentsLabel = new Label();
            txtDeanComments = new TextBox();
            txtDeanSignatureLabel = new Label();
            txtDeanSignature = new TextBox();
            txtDeanNameLabel = new Label();
            txtDeanName = new TextBox();
            txtDeanDateLabel = new Label();
            txtDeanDate = new TextBox();
            page3FormCode = new Label();
            page3Footer = new Label();
            commentsTitle4 = new Label();
            txtFacultyComments = new TextBox();
            page4FormCode = new Label();
            page4Footer = new Label();
            commentsTitle5 = new Label();
            txtStudentComments = new TextBox();
            page5FormCode = new Label();
            page5Footer = new Label();
            SuspendLayout();
            toolbar.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            page1.SuspendLayout();
            tabPage2.SuspendLayout();
            page2.SuspendLayout();
            tabPage3.SuspendLayout();
            page3.SuspendLayout();
            tabPage4.SuspendLayout();
            page4.SuspendLayout();
            tabPage5.SuspendLayout();
            page5.SuspendLayout();
            grpStudentReview.SuspendLayout();
            grpChairAgreement.SuspendLayout();
            grpDeanAgreement.SuspendLayout();
            // toolbar
            toolbar.Name = "toolbar";
            toolbar.Location = new Point(0, 0);
            toolbar.Size = new Size(1080, 103);
            toolbar.Dock = DockStyle.Top;
            toolbar.BackColor = Color.FromArgb(235, 240, 243);
            // recordIDLabel
            recordIDLabel.Name = "recordIDLabel";
            recordIDLabel.Location = new Point(18, 12);
            recordIDLabel.Size = new Size(75, 24);
            recordIDLabel.Text = "Record ID";
            recordIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            recordIDLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtRecordID
            txtRecordID.Name = "txtRecordID";
            txtRecordID.Location = new Point(92, 9);
            txtRecordID.Size = new Size(124, 27);
            txtRecordID.ReadOnly = true;
            // searchLabel
            searchLabel.Name = "searchLabel";
            searchLabel.Location = new Point(232, 12);
            searchLabel.Size = new Size(66, 24);
            searchLabel.Text = "Search by";
            searchLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            searchLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // cmbSearchBy
            cmbSearchBy.Name = "cmbSearchBy";
            cmbSearchBy.Location = new Point(304, 9);
            cmbSearchBy.Size = new Size(175, 28);
            cmbSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchBy.Items.AddRange(new object[] { "Student ID", "Student Name", "Course Name", "Course Number", "Faculty Name", "Department Name", "Term ID" });
            cmbSearchBy.SelectedIndex = 0;
            // txtSearch
            txtSearch.Name = "txtSearch";
            txtSearch.Location = new Point(490, 9);
            txtSearch.Size = new Size(380, 28);
            // btnSearch
            btnSearch.Name = "btnSearch";
            btnSearch.Location = new Point(882, 8);
            btnSearch.Size = new Size(112, 30);
            btnSearch.Text = "Search";
            // btnNew
            btnNew.Name = "btnNew";
            btnNew.Location = new Point(18, 52);
            btnNew.Size = new Size(112, 34);
            btnNew.Text = "New case";
            btnNew.UseVisualStyleBackColor = true;
            // btnUpdate
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Location = new Point(140, 52);
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // btnSave
            btnSave.Name = "btnSave";
            btnSave.Location = new Point(262, 52);
            btnSave.Size = new Size(112, 34);
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // btnDelete
            btnDelete.Name = "btnDelete";
            btnDelete.Location = new Point(384, 52);
            btnDelete.Size = new Size(112, 34);
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // btnCancel
            btnCancel.Name = "btnCancel";
            btnCancel.Location = new Point(506, 52);
            btnCancel.Size = new Size(112, 34);
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // btnLogin
            btnLogin.Name = "btnLogin";
            btnLogin.Location = new Point(628, 52);
            btnLogin.Size = new Size(112, 34);
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // btnRegister
            btnRegister.Name = "btnRegister";
            btnRegister.Location = new Point(750, 52);
            btnRegister.Size = new Size(112, 34);
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // btnLogout
            btnLogout.Name = "btnLogout";
            btnLogout.Location = new Point(872, 52);
            btnLogout.Size = new Size(112, 34);
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // tabControl1
            tabControl1.Name = "tabControl1";
            tabControl1.Location = new Point(0, 103);
            tabControl1.Size = new Size(1080, 760);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 10F);
            // tabPage1
            tabPage1.Name = "tabPage1";
            tabPage1.Location = new Point(4, 27);
            tabPage1.Size = new Size(1068, 729);
            tabPage1.Text = "Page 1 - Faculty report";
            tabPage1.AutoScroll = true;
            tabPage1.BackColor = Color.FromArgb(225, 229, 232);
            tabPage1.Padding = new Padding(12);
            // page1
            page1.Name = "page1";
            page1.Location = new Point(12, 12);
            page1.Size = new Size(980, 1200);
            page1.BackColor = Color.White;
            page1.BorderStyle = BorderStyle.FixedSingle;
            // tabPage2
            tabPage2.Name = "tabPage2";
            tabPage2.Location = new Point(4, 27);
            tabPage2.Size = new Size(1068, 729);
            tabPage2.Text = "Page 2 - Student response";
            tabPage2.AutoScroll = true;
            tabPage2.BackColor = Color.FromArgb(225, 229, 232);
            tabPage2.Padding = new Padding(12);
            // page2
            page2.Name = "page2";
            page2.Location = new Point(12, 12);
            page2.Size = new Size(980, 1100);
            page2.BackColor = Color.White;
            page2.BorderStyle = BorderStyle.FixedSingle;
            // tabPage3
            tabPage3.Name = "tabPage3";
            tabPage3.Location = new Point(4, 27);
            tabPage3.Size = new Size(1068, 729);
            tabPage3.Text = "Page 3 - Chair / Dean";
            tabPage3.AutoScroll = true;
            tabPage3.BackColor = Color.FromArgb(225, 229, 232);
            tabPage3.Padding = new Padding(12);
            // page3
            page3.Name = "page3";
            page3.Location = new Point(12, 12);
            page3.Size = new Size(980, 1120);
            page3.BackColor = Color.White;
            page3.BorderStyle = BorderStyle.FixedSingle;
            // tabPage4
            tabPage4.Name = "tabPage4";
            tabPage4.Location = new Point(4, 27);
            tabPage4.Size = new Size(1068, 729);
            tabPage4.Text = "Page 4 - Faculty comments";
            tabPage4.AutoScroll = true;
            tabPage4.BackColor = Color.FromArgb(225, 229, 232);
            tabPage4.Padding = new Padding(12);
            // page4
            page4.Name = "page4";
            page4.Location = new Point(12, 12);
            page4.Size = new Size(980, 1150);
            page4.BackColor = Color.White;
            page4.BorderStyle = BorderStyle.FixedSingle;
            // tabPage5
            tabPage5.Name = "tabPage5";
            tabPage5.Location = new Point(4, 27);
            tabPage5.Size = new Size(1068, 729);
            tabPage5.Text = "Page 5 - Student comments";
            tabPage5.AutoScroll = true;
            tabPage5.BackColor = Color.FromArgb(225, 229, 232);
            tabPage5.Padding = new Padding(12);
            // page5
            page5.Name = "page5";
            page5.Location = new Point(12, 12);
            page5.Size = new Size(980, 1150);
            page5.BackColor = Color.White;
            page5.BorderStyle = BorderStyle.FixedSingle;
            // osaLabel
            osaLabel.Name = "osaLabel";
            osaLabel.Location = new Point(28, 20);
            osaLabel.Size = new Size(300, 23);
            osaLabel.Text = "This space is for OSA use only.";
            osaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            osaLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtOSA
            txtOSA.Name = "txtOSA";
            txtOSA.Location = new Point(28, 44);
            txtOSA.Size = new Size(300, 48);
            txtOSA.Multiline = true;
            // university
            university.Name = "university";
            university.Location = new Point(650, 20);
            university.Size = new Size(300, 30);
            university.Text = "THOMPSON RIVERS UNIVERSITY";
            university.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            university.ForeColor = Color.FromArgb(30, 35, 40);
            // address
            address.Name = "address";
            address.Location = new Point(650, 52);
            address.Size = new Size(300, 67);
            address.Text = "805 TRU Way\nKamloops, BC, Canada\nV2C 0C8   |   tru.ca/aic";
            address.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            address.ForeColor = Color.FromArgb(30, 35, 40);
            // policyTitle
            policyTitle.Name = "policyTitle";
            policyTitle.Location = new Point(28, 114);
            policyTitle.Size = new Size(924, 35);
            policyTitle.Text = "ACADEMIC INTEGRITY POLICY ED 5-0";
            policyTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            policyTitle.ForeColor = Color.FromArgb(30, 35, 40);
            // caseTitle
            caseTitle.Name = "caseTitle";
            caseTitle.Location = new Point(28, 150);
            caseTitle.Size = new Size(924, 28);
            caseTitle.Text = "Case Report Form: On Campus Course";
            caseTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            caseTitle.ForeColor = Color.FromArgb(30, 35, 40);
            // printNote
            printNote.Name = "printNote";
            printNote.Location = new Point(34, 188);
            printNote.Size = new Size(912, 43);
            printNote.Text = "This form can be completed using a printed copy or electronically using Adobe Reader or Adobe Acrobat.";
            printNote.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            printNote.ForeColor = Color.FromArgb(30, 35, 40);
            // stepOne
            stepOne.Name = "stepOne";
            stepOne.Location = new Point(28, 234);
            stepOne.Size = new Size(924, 32);
            stepOne.Text = "Step One - To be completed by Faculty Member";
            stepOne.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            stepOne.BackColor = Color.FromArgb(20, 54, 76);
            stepOne.ForeColor = Color.White;
            stepOne.TextAlign = ContentAlignment.MiddleLeft;
            stepOne.Padding = new Padding(8, 0, 0, 0);
            // facultyInstructions
            facultyInstructions.Name = "facultyInstructions";
            facultyInstructions.Location = new Point(34, 278);
            facultyInstructions.Size = new Size(912, 144);
            facultyInstructions.Text = "Faculty Member:\n1. Complete the form below. Include only one student assignment or case in each form.\n2. Provide comments and evidence highlighting the violation of ED 5-0. Submissions will not be accepted without evidence.\n3. Sign the form. Do not make changes after signing.\n4. Save as <studentlastname_coursenumber_month_year.pdf>.\n5. Attach the form and evidence to an email to the student, or meet the student in person.";
            facultyInstructions.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            facultyInstructions.ForeColor = Color.FromArgb(30, 35, 40);
            // txtStudentNameLabel
            txtStudentNameLabel.Name = "txtStudentNameLabel";
            txtStudentNameLabel.Location = new Point(34, 430);
            txtStudentNameLabel.Size = new Size(330, 21);
            txtStudentNameLabel.Text = "Student Name";
            txtStudentNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtStudentNameLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtStudentName
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Location = new Point(34, 453);
            txtStudentName.Size = new Size(330, 29);
            txtStudentName.Font = new Font("Segoe UI", 10F);
            txtStudentName.BorderStyle = BorderStyle.FixedSingle;
            // txtStudentIDLabel
            txtStudentIDLabel.Name = "txtStudentIDLabel";
            txtStudentIDLabel.Location = new Point(376, 430);
            txtStudentIDLabel.Size = new Size(235, 21);
            txtStudentIDLabel.Text = "Student Number";
            txtStudentIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtStudentIDLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtStudentID
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Location = new Point(376, 453);
            txtStudentID.Size = new Size(235, 29);
            txtStudentID.Font = new Font("Segoe UI", 10F);
            txtStudentID.BorderStyle = BorderStyle.FixedSingle;
            // txtStudentEmailLabel
            txtStudentEmailLabel.Name = "txtStudentEmailLabel";
            txtStudentEmailLabel.Location = new Point(623, 430);
            txtStudentEmailLabel.Size = new Size(323, 21);
            txtStudentEmailLabel.Text = "Student Email";
            txtStudentEmailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtStudentEmailLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtStudentEmail
            txtStudentEmail.Name = "txtStudentEmail";
            txtStudentEmail.Location = new Point(623, 453);
            txtStudentEmail.Size = new Size(323, 29);
            txtStudentEmail.Font = new Font("Segoe UI", 10F);
            txtStudentEmail.BorderStyle = BorderStyle.FixedSingle;
            // txtFacultyNameLabel
            txtFacultyNameLabel.Name = "txtFacultyNameLabel";
            txtFacultyNameLabel.Location = new Point(34, 494);
            txtFacultyNameLabel.Size = new Size(330, 21);
            txtFacultyNameLabel.Text = "Faculty Member Name";
            txtFacultyNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtFacultyNameLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtFacultyName
            txtFacultyName.Name = "txtFacultyName";
            txtFacultyName.Location = new Point(34, 517);
            txtFacultyName.Size = new Size(330, 29);
            txtFacultyName.Font = new Font("Segoe UI", 10F);
            txtFacultyName.BorderStyle = BorderStyle.FixedSingle;
            // txtCaseDateLabel
            txtCaseDateLabel.Name = "txtCaseDateLabel";
            txtCaseDateLabel.Location = new Point(376, 494);
            txtCaseDateLabel.Size = new Size(235, 21);
            txtCaseDateLabel.Text = "Date (yyyy-mm-dd)";
            txtCaseDateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCaseDateLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtCaseDate
            txtCaseDate.Name = "txtCaseDate";
            txtCaseDate.Location = new Point(376, 517);
            txtCaseDate.Size = new Size(235, 29);
            txtCaseDate.Font = new Font("Segoe UI", 10F);
            txtCaseDate.BorderStyle = BorderStyle.FixedSingle;
            // txtCourseNameLabel
            txtCourseNameLabel.Name = "txtCourseNameLabel";
            txtCourseNameLabel.Location = new Point(623, 494);
            txtCourseNameLabel.Size = new Size(196, 21);
            txtCourseNameLabel.Text = "Course Name";
            txtCourseNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCourseNameLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtCourseName
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Location = new Point(623, 517);
            txtCourseName.Size = new Size(196, 29);
            txtCourseName.Font = new Font("Segoe UI", 10F);
            txtCourseName.BorderStyle = BorderStyle.FixedSingle;
            // txtCourseNumberLabel
            txtCourseNumberLabel.Name = "txtCourseNumberLabel";
            txtCourseNumberLabel.Location = new Point(831, 494);
            txtCourseNumberLabel.Size = new Size(115, 21);
            txtCourseNumberLabel.Text = "Course Number";
            txtCourseNumberLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCourseNumberLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtCourseNumber
            txtCourseNumber.Name = "txtCourseNumber";
            txtCourseNumber.Location = new Point(831, 517);
            txtCourseNumber.Size = new Size(115, 29);
            txtCourseNumber.Font = new Font("Segoe UI", 10F);
            txtCourseNumber.BorderStyle = BorderStyle.FixedSingle;
            // txtAssignmentLabel
            txtAssignmentLabel.Name = "txtAssignmentLabel";
            txtAssignmentLabel.Location = new Point(34, 558);
            txtAssignmentLabel.Size = new Size(330, 21);
            txtAssignmentLabel.Text = "Assignment Number or Exam";
            txtAssignmentLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtAssignmentLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtAssignment
            txtAssignment.Name = "txtAssignment";
            txtAssignment.Location = new Point(34, 581);
            txtAssignment.Size = new Size(330, 29);
            txtAssignment.Font = new Font("Segoe UI", 10F);
            txtAssignment.BorderStyle = BorderStyle.FixedSingle;
            // txtDepartmentLabel
            txtDepartmentLabel.Name = "txtDepartmentLabel";
            txtDepartmentLabel.Location = new Point(376, 558);
            txtDepartmentLabel.Size = new Size(235, 21);
            txtDepartmentLabel.Text = "Department";
            txtDepartmentLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtDepartmentLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtDepartment
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Location = new Point(376, 581);
            txtDepartment.Size = new Size(235, 29);
            txtDepartment.Font = new Font("Segoe UI", 10F);
            txtDepartment.BorderStyle = BorderStyle.FixedSingle;
            // txtTermIDLabel
            txtTermIDLabel.Name = "txtTermIDLabel";
            txtTermIDLabel.Location = new Point(623, 558);
            txtTermIDLabel.Size = new Size(323, 21);
            txtTermIDLabel.Text = "Term or Semester (Term ID)";
            txtTermIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtTermIDLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtTermID
            txtTermID.Name = "txtTermID";
            txtTermID.Location = new Point(623, 581);
            txtTermID.Size = new Size(323, 29);
            txtTermID.Font = new Font("Segoe UI", 10F);
            txtTermID.BorderStyle = BorderStyle.FixedSingle;
            // txtViolationLabel
            txtViolationLabel.Name = "txtViolationLabel";
            txtViolationLabel.Location = new Point(34, 624);
            txtViolationLabel.Size = new Size(912, 21);
            txtViolationLabel.Text = "Description of Violation of Academic Integrity Policy ED 5-0 (use Page 4 if more room is needed)";
            txtViolationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtViolationLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtViolation
            txtViolation.Name = "txtViolation";
            txtViolation.Location = new Point(34, 647);
            txtViolation.Size = new Size(912, 118);
            txtViolation.Font = new Font("Segoe UI", 10F);
            txtViolation.BorderStyle = BorderStyle.FixedSingle;
            txtViolation.Multiline = true;
            txtViolation.ScrollBars = ScrollBars.Vertical;
            txtViolation.AcceptsReturn = true;
            // sanctionGuidance
            sanctionGuidance.Name = "sanctionGuidance";
            sanctionGuidance.Location = new Point(34, 779);
            sanctionGuidance.Size = new Size(912, 71);
            sanctionGuidance.Text = "Recommendations for sanction: Typical sanctions include reprimand, reduction of grade, zero for assignment/exam, remedial sanctions, failure of course, and suspension. Decisions are made by the Academic Integrity Committee. Provide evidence on Page 4 for any specific sanction.";
            sanctionGuidance.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            sanctionGuidance.ForeColor = Color.FromArgb(30, 35, 40);
            // txtSanctionsLabel
            txtSanctionsLabel.Name = "txtSanctionsLabel";
            txtSanctionsLabel.Location = new Point(34, 853);
            txtSanctionsLabel.Size = new Size(912, 21);
            txtSanctionsLabel.Text = "Recommended sanction";
            txtSanctionsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtSanctionsLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtSanctions
            txtSanctions.Name = "txtSanctions";
            txtSanctions.Location = new Point(34, 876);
            txtSanctions.Size = new Size(912, 68);
            txtSanctions.Font = new Font("Segoe UI", 10F);
            txtSanctions.BorderStyle = BorderStyle.FixedSingle;
            txtSanctions.Multiline = true;
            txtSanctions.ScrollBars = ScrollBars.Vertical;
            txtSanctions.AcceptsReturn = true;
            // chkSupportPerson
            chkSupportPerson.Name = "chkSupportPerson";
            chkSupportPerson.Location = new Point(35, 948);
            chkSupportPerson.Size = new Size(905, 48);
            chkSupportPerson.Text = "The student is advised that they may bring a support person to the meeting at which the Case Report Form and evidence will be reviewed.";
            chkSupportPerson.Font = new Font("Segoe UI", 10F);
            // chkWrittenStatement
            chkWrittenStatement.Name = "chkWrittenStatement";
            chkWrittenStatement.Location = new Point(35, 996);
            chkWrittenStatement.Size = new Size(905, 48);
            chkWrittenStatement.Text = "The student is advised that they may submit a written statement to the Academic Integrity Committee by email to aic@tru.ca.";
            chkWrittenStatement.Font = new Font("Segoe UI", 10F);
            // txtInitialFacultySignatureLabel
            txtInitialFacultySignatureLabel.Name = "txtInitialFacultySignatureLabel";
            txtInitialFacultySignatureLabel.Location = new Point(34, 1053);
            txtInitialFacultySignatureLabel.Size = new Size(340, 21);
            txtInitialFacultySignatureLabel.Text = "Signature of Faculty Member";
            txtInitialFacultySignatureLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtInitialFacultySignatureLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtInitialFacultySignature
            txtInitialFacultySignature.Name = "txtInitialFacultySignature";
            txtInitialFacultySignature.Location = new Point(34, 1076);
            txtInitialFacultySignature.Size = new Size(340, 29);
            txtInitialFacultySignature.Font = new Font("Segoe UI", 10F);
            txtInitialFacultySignature.BorderStyle = BorderStyle.FixedSingle;
            // txtInitialFacultyNameLabel
            txtInitialFacultyNameLabel.Name = "txtInitialFacultyNameLabel";
            txtInitialFacultyNameLabel.Location = new Point(386, 1053);
            txtInitialFacultyNameLabel.Size = new Size(280, 21);
            txtInitialFacultyNameLabel.Text = "Name of Faculty Member";
            txtInitialFacultyNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtInitialFacultyNameLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtInitialFacultyName
            txtInitialFacultyName.Name = "txtInitialFacultyName";
            txtInitialFacultyName.Location = new Point(386, 1076);
            txtInitialFacultyName.Size = new Size(280, 29);
            txtInitialFacultyName.Font = new Font("Segoe UI", 10F);
            txtInitialFacultyName.BorderStyle = BorderStyle.FixedSingle;
            // txtInitialFacultyDateLabel
            txtInitialFacultyDateLabel.Name = "txtInitialFacultyDateLabel";
            txtInitialFacultyDateLabel.Location = new Point(678, 1053);
            txtInitialFacultyDateLabel.Size = new Size(268, 21);
            txtInitialFacultyDateLabel.Text = "Date (yyyy-mm-dd)";
            txtInitialFacultyDateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtInitialFacultyDateLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtInitialFacultyDate
            txtInitialFacultyDate.Name = "txtInitialFacultyDate";
            txtInitialFacultyDate.Location = new Point(678, 1076);
            txtInitialFacultyDate.Size = new Size(268, 29);
            txtInitialFacultyDate.Font = new Font("Segoe UI", 10F);
            txtInitialFacultyDate.BorderStyle = BorderStyle.FixedSingle;
            // page1FormCode
            page1FormCode.Name = "page1FormCode";
            page1FormCode.Location = new Point(28, 1135);
            page1FormCode.Size = new Size(924, 20);
            page1FormCode.Text = "FSD21001";
            page1FormCode.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            page1FormCode.ForeColor = Color.FromArgb(30, 35, 40);
            // page1Footer
            page1Footer.Name = "page1Footer";
            page1Footer.Location = new Point(28, 1155);
            page1Footer.Size = new Size(924, 25);
            page1Footer.Text = "PAGE 1 of 5";
            page1Footer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            page1Footer.ForeColor = Color.FromArgb(30, 35, 40);
            page1FormCode.TextAlign = ContentAlignment.MiddleRight;
            page1Footer.TextAlign = ContentAlignment.MiddleCenter;
            // stepTwo
            stepTwo.Name = "stepTwo";
            stepTwo.Location = new Point(28, 26);
            stepTwo.Size = new Size(924, 32);
            stepTwo.Text = "Step Two - To be completed by Student within seven (7) days of receipt";
            stepTwo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            stepTwo.BackColor = Color.FromArgb(20, 54, 76);
            stepTwo.ForeColor = Color.White;
            stepTwo.TextAlign = ContentAlignment.MiddleLeft;
            stepTwo.Padding = new Padding(8, 0, 0, 0);
            // studentInstructions
            studentInstructions.Name = "studentInstructions";
            studentInstructions.Location = new Point(34, 70);
            studentInstructions.Size = new Size(912, 155);
            studentInstructions.Text = "1. Read your case and evidence from the Faculty Member.\n2. Answer the question below by checking either Yes or No.\n3. Enter the date.\n4. Enter your signature. Do not make changes after signing.\n5. Save this form and email it back to the Faculty Member within seven days of receipt.\n6. If this form is not returned within seven days, the Faculty Member will proceed.";
            studentInstructions.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            studentInstructions.ForeColor = Color.FromArgb(30, 35, 40);
            // txtAcknowledgedStudentLabel
            txtAcknowledgedStudentLabel.Name = "txtAcknowledgedStudentLabel";
            txtAcknowledgedStudentLabel.Location = new Point(34, 233);
            txtAcknowledgedStudentLabel.Size = new Size(912, 21);
            txtAcknowledgedStudentLabel.Text = "I, (STUDENT NAME, TYPED or PRINTED)";
            txtAcknowledgedStudentLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtAcknowledgedStudentLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtAcknowledgedStudent
            txtAcknowledgedStudent.Name = "txtAcknowledgedStudent";
            txtAcknowledgedStudent.Location = new Point(34, 256);
            txtAcknowledgedStudent.Size = new Size(912, 29);
            txtAcknowledgedStudent.Font = new Font("Segoe UI", 10F);
            txtAcknowledgedStudent.BorderStyle = BorderStyle.FixedSingle;
            // acknowledgmentText
            acknowledgmentText.Name = "acknowledgmentText";
            acknowledgmentText.Location = new Point(34, 296);
            acknowledgmentText.Size = new Size(912, 180);
            acknowledgmentText.Text = "I have been made aware of Academic Integrity Policy ED 5-0, as well as my alleged violation of this policy.\nI am aware that I will be given an opportunity to make a written submission to the Academic Integrity Committee and have the right to appeal under ED 4-0 and ED 5-0.\nI may contact the Office of Student Affairs for assistance. A record will be held confidentially in the Office of Student Affairs.\nEmail: aic@tru.ca or Phone: 250-828-5023";
            acknowledgmentText.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            acknowledgmentText.ForeColor = Color.FromArgb(30, 35, 40);
            // grpStudentReview
            grpStudentReview.Name = "grpStudentReview";
            grpStudentReview.Location = new Point(34, 481);
            grpStudentReview.Size = new Size(420, 55);
            grpStudentReview.BorderStyle = BorderStyle.None;
            // grpStudentReviewQuestion
            grpStudentReviewQuestion.Name = "grpStudentReviewQuestion";
            grpStudentReviewQuestion.Location = new Point(0, 0);
            grpStudentReviewQuestion.Size = new Size(300, 48);
            grpStudentReviewQuestion.Text = "I have reviewed the information in the form as well as the evidence:";
            grpStudentReviewQuestion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpStudentReviewQuestion.ForeColor = Color.FromArgb(30, 35, 40);
            // grpStudentReviewYes
            grpStudentReviewYes.Name = "grpStudentReviewYes";
            grpStudentReviewYes.Location = new Point(304, 3);
            grpStudentReviewYes.Size = new Size(54, 25);
            grpStudentReviewYes.Text = "Yes";
            // grpStudentReviewNo
            grpStudentReviewNo.Name = "grpStudentReviewNo";
            grpStudentReviewNo.Location = new Point(360, 3);
            grpStudentReviewNo.Size = new Size(55, 25);
            grpStudentReviewNo.Text = "No";
            // studentCommentsNote
            studentCommentsNote.Name = "studentCommentsNote";
            studentCommentsNote.Location = new Point(484, 481);
            studentCommentsNote.Size = new Size(462, 55);
            studentCommentsNote.Text = "Further comments may be added on Page 5 to explain your case.";
            studentCommentsNote.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            studentCommentsNote.ForeColor = Color.FromArgb(30, 35, 40);
            // txtMyTRUEmailLabel
            txtMyTRUEmailLabel.Name = "txtMyTRUEmailLabel";
            txtMyTRUEmailLabel.Location = new Point(34, 548);
            txtMyTRUEmailLabel.Size = new Size(912, 21);
            txtMyTRUEmailLabel.Text = "MyTRU email*";
            txtMyTRUEmailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtMyTRUEmailLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtMyTRUEmail
            txtMyTRUEmail.Name = "txtMyTRUEmail";
            txtMyTRUEmail.Location = new Point(34, 571);
            txtMyTRUEmail.Size = new Size(912, 29);
            txtMyTRUEmail.Font = new Font("Segoe UI", 10F);
            txtMyTRUEmail.BorderStyle = BorderStyle.FixedSingle;
            // txtStudentSignatureLabel
            txtStudentSignatureLabel.Name = "txtStudentSignatureLabel";
            txtStudentSignatureLabel.Location = new Point(34, 614);
            txtStudentSignatureLabel.Size = new Size(625, 21);
            txtStudentSignatureLabel.Text = "Signature of Student";
            txtStudentSignatureLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtStudentSignatureLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtStudentSignature
            txtStudentSignature.Name = "txtStudentSignature";
            txtStudentSignature.Location = new Point(34, 637);
            txtStudentSignature.Size = new Size(625, 29);
            txtStudentSignature.Font = new Font("Segoe UI", 10F);
            txtStudentSignature.BorderStyle = BorderStyle.FixedSingle;
            // txtStudentDateLabel
            txtStudentDateLabel.Name = "txtStudentDateLabel";
            txtStudentDateLabel.Location = new Point(678, 614);
            txtStudentDateLabel.Size = new Size(268, 21);
            txtStudentDateLabel.Text = "Date (yyyy-mm-dd)";
            txtStudentDateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtStudentDateLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtStudentDate
            txtStudentDate.Name = "txtStudentDate";
            txtStudentDate.Location = new Point(678, 637);
            txtStudentDate.Size = new Size(268, 29);
            txtStudentDate.Font = new Font("Segoe UI", 10F);
            txtStudentDate.BorderStyle = BorderStyle.FixedSingle;
            // emailNote
            emailNote.Name = "emailNote";
            emailNote.Location = new Point(34, 680);
            emailNote.Size = new Size(912, 38);
            emailNote.Text = "*All official correspondence from the committee will be sent to students at their @mytru.ca email address.";
            emailNote.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            emailNote.ForeColor = Color.FromArgb(30, 35, 40);
            // stepThree
            stepThree.Name = "stepThree";
            stepThree.Location = new Point(28, 728);
            stepThree.Size = new Size(924, 32);
            stepThree.Text = "Step Three - To be completed by Faculty Member";
            stepThree.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            stepThree.BackColor = Color.FromArgb(20, 54, 76);
            stepThree.ForeColor = Color.White;
            stepThree.TextAlign = ContentAlignment.MiddleLeft;
            stepThree.Padding = new Padding(8, 0, 0, 0);
            // facultyFollowup
            facultyFollowup.Name = "facultyFollowup";
            facultyFollowup.Location = new Point(34, 772);
            facultyFollowup.Size = new Size(912, 170);
            facultyFollowup.Text = "When you receive this form back from the student, proceed with #1. If the form is not returned within seven days, proceed with #2.\n1. Check to ensure that the student has signed the form.\n2. Sign the form. Do not make changes after signing.\n3. Save the form to your computer.\n4. Forward this form to the Department Chair with a copy of the evidence within seven days.";
            facultyFollowup.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            facultyFollowup.ForeColor = Color.FromArgb(30, 35, 40);
            // txtFollowupFacultySignatureLabel
            txtFollowupFacultySignatureLabel.Name = "txtFollowupFacultySignatureLabel";
            txtFollowupFacultySignatureLabel.Location = new Point(34, 950);
            txtFollowupFacultySignatureLabel.Size = new Size(340, 21);
            txtFollowupFacultySignatureLabel.Text = "Signature of Faculty Member";
            txtFollowupFacultySignatureLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtFollowupFacultySignatureLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtFollowupFacultySignature
            txtFollowupFacultySignature.Name = "txtFollowupFacultySignature";
            txtFollowupFacultySignature.Location = new Point(34, 973);
            txtFollowupFacultySignature.Size = new Size(340, 29);
            txtFollowupFacultySignature.Font = new Font("Segoe UI", 10F);
            txtFollowupFacultySignature.BorderStyle = BorderStyle.FixedSingle;
            // txtFollowupFacultyNameLabel
            txtFollowupFacultyNameLabel.Name = "txtFollowupFacultyNameLabel";
            txtFollowupFacultyNameLabel.Location = new Point(386, 950);
            txtFollowupFacultyNameLabel.Size = new Size(280, 21);
            txtFollowupFacultyNameLabel.Text = "Name of Faculty Member";
            txtFollowupFacultyNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtFollowupFacultyNameLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtFollowupFacultyName
            txtFollowupFacultyName.Name = "txtFollowupFacultyName";
            txtFollowupFacultyName.Location = new Point(386, 973);
            txtFollowupFacultyName.Size = new Size(280, 29);
            txtFollowupFacultyName.Font = new Font("Segoe UI", 10F);
            txtFollowupFacultyName.BorderStyle = BorderStyle.FixedSingle;
            // txtFollowupFacultyDateLabel
            txtFollowupFacultyDateLabel.Name = "txtFollowupFacultyDateLabel";
            txtFollowupFacultyDateLabel.Location = new Point(678, 950);
            txtFollowupFacultyDateLabel.Size = new Size(268, 21);
            txtFollowupFacultyDateLabel.Text = "Date (yyyy-mm-dd)";
            txtFollowupFacultyDateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtFollowupFacultyDateLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtFollowupFacultyDate
            txtFollowupFacultyDate.Name = "txtFollowupFacultyDate";
            txtFollowupFacultyDate.Location = new Point(678, 973);
            txtFollowupFacultyDate.Size = new Size(268, 29);
            txtFollowupFacultyDate.Font = new Font("Segoe UI", 10F);
            txtFollowupFacultyDate.BorderStyle = BorderStyle.FixedSingle;
            // page2FormCode
            page2FormCode.Name = "page2FormCode";
            page2FormCode.Location = new Point(28, 1038);
            page2FormCode.Size = new Size(924, 20);
            page2FormCode.Text = "FSD21001";
            page2FormCode.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            page2FormCode.ForeColor = Color.FromArgb(30, 35, 40);
            // page2Footer
            page2Footer.Name = "page2Footer";
            page2Footer.Location = new Point(28, 1058);
            page2Footer.Size = new Size(924, 25);
            page2Footer.Text = "PAGE 2 of 5";
            page2Footer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            page2Footer.ForeColor = Color.FromArgb(30, 35, 40);
            page2FormCode.TextAlign = ContentAlignment.MiddleRight;
            page2Footer.TextAlign = ContentAlignment.MiddleCenter;
            // stepFour
            stepFour.Name = "stepFour";
            stepFour.Location = new Point(28, 26);
            stepFour.Size = new Size(924, 32);
            stepFour.Text = "Step Four - To be completed by the Department Chair";
            stepFour.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            stepFour.BackColor = Color.FromArgb(20, 54, 76);
            stepFour.ForeColor = Color.White;
            stepFour.TextAlign = ContentAlignment.MiddleLeft;
            stepFour.Padding = new Padding(8, 0, 0, 0);
            // chairInstructions
            chairInstructions.Name = "chairInstructions";
            chairInstructions.Location = new Point(34, 70);
            chairInstructions.Size = new Size(912, 157);
            chairInstructions.Text = "All cases in which the Academic Integrity Policy is alleged to have been breached shall be reviewed by the Department Chair.\nDepartment Chair (or designate):\n1. Check that both student and Faculty Member have signed the form.\n2. Answer the question below.  3. Ensure that the evidence is attached.\n4. Sign the form. Do not make changes after signing.\n5. Save and forward the form and attachments to the Dean within seven days.";
            chairInstructions.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            chairInstructions.ForeColor = Color.FromArgb(30, 35, 40);
            // grpChairAgreement
            grpChairAgreement.Name = "grpChairAgreement";
            grpChairAgreement.Location = new Point(34, 236);
            grpChairAgreement.Size = new Size(420, 55);
            grpChairAgreement.BorderStyle = BorderStyle.None;
            // grpChairAgreementQuestion
            grpChairAgreementQuestion.Name = "grpChairAgreementQuestion";
            grpChairAgreementQuestion.Location = new Point(0, 0);
            grpChairAgreementQuestion.Size = new Size(300, 48);
            grpChairAgreementQuestion.Text = "I agree with the particulars of the case described in this document:";
            grpChairAgreementQuestion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpChairAgreementQuestion.ForeColor = Color.FromArgb(30, 35, 40);
            // grpChairAgreementYes
            grpChairAgreementYes.Name = "grpChairAgreementYes";
            grpChairAgreementYes.Location = new Point(304, 3);
            grpChairAgreementYes.Size = new Size(54, 25);
            grpChairAgreementYes.Text = "Yes";
            // grpChairAgreementNo
            grpChairAgreementNo.Name = "grpChairAgreementNo";
            grpChairAgreementNo.Location = new Point(360, 3);
            grpChairAgreementNo.Size = new Size(55, 25);
            grpChairAgreementNo.Text = "No";
            // txtChairExplanationLabel
            txtChairExplanationLabel.Name = "txtChairExplanationLabel";
            txtChairExplanationLabel.Location = new Point(484, 230);
            txtChairExplanationLabel.Size = new Size(462, 21);
            txtChairExplanationLabel.Text = "If you have checked No, please explain.";
            txtChairExplanationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtChairExplanationLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtChairExplanation
            txtChairExplanation.Name = "txtChairExplanation";
            txtChairExplanation.Location = new Point(484, 253);
            txtChairExplanation.Size = new Size(462, 70);
            txtChairExplanation.Font = new Font("Segoe UI", 10F);
            txtChairExplanation.BorderStyle = BorderStyle.FixedSingle;
            txtChairExplanation.Multiline = true;
            txtChairExplanation.ScrollBars = ScrollBars.Vertical;
            txtChairExplanation.AcceptsReturn = true;
            // txtChairCommentsLabel
            txtChairCommentsLabel.Name = "txtChairCommentsLabel";
            txtChairCommentsLabel.Location = new Point(34, 336);
            txtChairCommentsLabel.Size = new Size(912, 21);
            txtChairCommentsLabel.Text = "Comments";
            txtChairCommentsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtChairCommentsLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtChairComments
            txtChairComments.Name = "txtChairComments";
            txtChairComments.Location = new Point(34, 359);
            txtChairComments.Size = new Size(912, 114);
            txtChairComments.Font = new Font("Segoe UI", 10F);
            txtChairComments.BorderStyle = BorderStyle.FixedSingle;
            txtChairComments.Multiline = true;
            txtChairComments.ScrollBars = ScrollBars.Vertical;
            txtChairComments.AcceptsReturn = true;
            // txtChairSignatureLabel
            txtChairSignatureLabel.Name = "txtChairSignatureLabel";
            txtChairSignatureLabel.Location = new Point(34, 486);
            txtChairSignatureLabel.Size = new Size(340, 21);
            txtChairSignatureLabel.Text = "Signature of Department Chair";
            txtChairSignatureLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtChairSignatureLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtChairSignature
            txtChairSignature.Name = "txtChairSignature";
            txtChairSignature.Location = new Point(34, 509);
            txtChairSignature.Size = new Size(340, 29);
            txtChairSignature.Font = new Font("Segoe UI", 10F);
            txtChairSignature.BorderStyle = BorderStyle.FixedSingle;
            // txtChairNameLabel
            txtChairNameLabel.Name = "txtChairNameLabel";
            txtChairNameLabel.Location = new Point(386, 486);
            txtChairNameLabel.Size = new Size(280, 21);
            txtChairNameLabel.Text = "Name of Department Chair";
            txtChairNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtChairNameLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtChairName
            txtChairName.Name = "txtChairName";
            txtChairName.Location = new Point(386, 509);
            txtChairName.Size = new Size(280, 29);
            txtChairName.Font = new Font("Segoe UI", 10F);
            txtChairName.BorderStyle = BorderStyle.FixedSingle;
            // txtChairDateLabel
            txtChairDateLabel.Name = "txtChairDateLabel";
            txtChairDateLabel.Location = new Point(678, 486);
            txtChairDateLabel.Size = new Size(268, 21);
            txtChairDateLabel.Text = "Date (yyyy-mm-dd)";
            txtChairDateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtChairDateLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtChairDate
            txtChairDate.Name = "txtChairDate";
            txtChairDate.Location = new Point(678, 509);
            txtChairDate.Size = new Size(268, 29);
            txtChairDate.Font = new Font("Segoe UI", 10F);
            txtChairDate.BorderStyle = BorderStyle.FixedSingle;
            // stepFive
            stepFive.Name = "stepFive";
            stepFive.Location = new Point(28, 563);
            stepFive.Size = new Size(924, 32);
            stepFive.Text = "Step Five - To be completed by the Dean";
            stepFive.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            stepFive.BackColor = Color.FromArgb(20, 54, 76);
            stepFive.ForeColor = Color.White;
            stepFive.TextAlign = ContentAlignment.MiddleLeft;
            stepFive.Padding = new Padding(8, 0, 0, 0);
            // deanInstructions
            deanInstructions.Name = "deanInstructions";
            deanInstructions.Location = new Point(34, 607);
            deanInstructions.Size = new Size(912, 167);
            deanInstructions.Text = "All cases in which the Academic Integrity Policy is alleged to have been breached shall be reviewed by the Dean. Cases reaching the Academic Integrity Committee must be forwarded by the Dean (or designate).\n1. Check that the student, Faculty Member and Chair have signed.\n2. Answer the question below.  3. Ensure supporting evidence is attached.\n4. Sign the form.  5. Save the form.\n6. Submit the case package within seven days to aic@tru.ca or the Office of Student Affairs.";
            deanInstructions.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            deanInstructions.ForeColor = Color.FromArgb(30, 35, 40);
            // grpDeanAgreement
            grpDeanAgreement.Name = "grpDeanAgreement";
            grpDeanAgreement.Location = new Point(34, 783);
            grpDeanAgreement.Size = new Size(420, 55);
            grpDeanAgreement.BorderStyle = BorderStyle.None;
            // grpDeanAgreementQuestion
            grpDeanAgreementQuestion.Name = "grpDeanAgreementQuestion";
            grpDeanAgreementQuestion.Location = new Point(0, 0);
            grpDeanAgreementQuestion.Size = new Size(300, 48);
            grpDeanAgreementQuestion.Text = "I agree with the particulars of the case described in this document:";
            grpDeanAgreementQuestion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDeanAgreementQuestion.ForeColor = Color.FromArgb(30, 35, 40);
            // grpDeanAgreementYes
            grpDeanAgreementYes.Name = "grpDeanAgreementYes";
            grpDeanAgreementYes.Location = new Point(304, 3);
            grpDeanAgreementYes.Size = new Size(54, 25);
            grpDeanAgreementYes.Text = "Yes";
            // grpDeanAgreementNo
            grpDeanAgreementNo.Name = "grpDeanAgreementNo";
            grpDeanAgreementNo.Location = new Point(360, 3);
            grpDeanAgreementNo.Size = new Size(55, 25);
            grpDeanAgreementNo.Text = "No";
            // txtDeanExplanationLabel
            txtDeanExplanationLabel.Name = "txtDeanExplanationLabel";
            txtDeanExplanationLabel.Location = new Point(484, 777);
            txtDeanExplanationLabel.Size = new Size(462, 21);
            txtDeanExplanationLabel.Text = "If you have checked No, please explain.";
            txtDeanExplanationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtDeanExplanationLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtDeanExplanation
            txtDeanExplanation.Name = "txtDeanExplanation";
            txtDeanExplanation.Location = new Point(484, 800);
            txtDeanExplanation.Size = new Size(462, 70);
            txtDeanExplanation.Font = new Font("Segoe UI", 10F);
            txtDeanExplanation.BorderStyle = BorderStyle.FixedSingle;
            txtDeanExplanation.Multiline = true;
            txtDeanExplanation.ScrollBars = ScrollBars.Vertical;
            txtDeanExplanation.AcceptsReturn = true;
            // txtDeanCommentsLabel
            txtDeanCommentsLabel.Name = "txtDeanCommentsLabel";
            txtDeanCommentsLabel.Location = new Point(34, 882);
            txtDeanCommentsLabel.Size = new Size(912, 21);
            txtDeanCommentsLabel.Text = "Comments";
            txtDeanCommentsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtDeanCommentsLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtDeanComments
            txtDeanComments.Name = "txtDeanComments";
            txtDeanComments.Location = new Point(34, 905);
            txtDeanComments.Size = new Size(912, 82);
            txtDeanComments.Font = new Font("Segoe UI", 10F);
            txtDeanComments.BorderStyle = BorderStyle.FixedSingle;
            txtDeanComments.Multiline = true;
            txtDeanComments.ScrollBars = ScrollBars.Vertical;
            txtDeanComments.AcceptsReturn = true;
            // txtDeanSignatureLabel
            txtDeanSignatureLabel.Name = "txtDeanSignatureLabel";
            txtDeanSignatureLabel.Location = new Point(34, 995);
            txtDeanSignatureLabel.Size = new Size(340, 21);
            txtDeanSignatureLabel.Text = "Signature of Dean";
            txtDeanSignatureLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtDeanSignatureLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtDeanSignature
            txtDeanSignature.Name = "txtDeanSignature";
            txtDeanSignature.Location = new Point(34, 1018);
            txtDeanSignature.Size = new Size(340, 29);
            txtDeanSignature.Font = new Font("Segoe UI", 10F);
            txtDeanSignature.BorderStyle = BorderStyle.FixedSingle;
            // txtDeanNameLabel
            txtDeanNameLabel.Name = "txtDeanNameLabel";
            txtDeanNameLabel.Location = new Point(386, 995);
            txtDeanNameLabel.Size = new Size(280, 21);
            txtDeanNameLabel.Text = "Name of Dean";
            txtDeanNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtDeanNameLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtDeanName
            txtDeanName.Name = "txtDeanName";
            txtDeanName.Location = new Point(386, 1018);
            txtDeanName.Size = new Size(280, 29);
            txtDeanName.Font = new Font("Segoe UI", 10F);
            txtDeanName.BorderStyle = BorderStyle.FixedSingle;
            // txtDeanDateLabel
            txtDeanDateLabel.Name = "txtDeanDateLabel";
            txtDeanDateLabel.Location = new Point(678, 995);
            txtDeanDateLabel.Size = new Size(268, 21);
            txtDeanDateLabel.Text = "Date (yyyy-mm-dd)";
            txtDeanDateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtDeanDateLabel.ForeColor = Color.FromArgb(30, 35, 40);
            // txtDeanDate
            txtDeanDate.Name = "txtDeanDate";
            txtDeanDate.Location = new Point(678, 1018);
            txtDeanDate.Size = new Size(268, 29);
            txtDeanDate.Font = new Font("Segoe UI", 10F);
            txtDeanDate.BorderStyle = BorderStyle.FixedSingle;
            // page3FormCode
            page3FormCode.Name = "page3FormCode";
            page3FormCode.Location = new Point(28, 1071);
            page3FormCode.Size = new Size(924, 20);
            page3FormCode.Text = "FSD21001";
            page3FormCode.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            page3FormCode.ForeColor = Color.FromArgb(30, 35, 40);
            // page3Footer
            page3Footer.Name = "page3Footer";
            page3Footer.Location = new Point(28, 1091);
            page3Footer.Size = new Size(924, 25);
            page3Footer.Text = "PAGE 3 of 5";
            page3Footer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            page3Footer.ForeColor = Color.FromArgb(30, 35, 40);
            page3FormCode.TextAlign = ContentAlignment.MiddleRight;
            page3Footer.TextAlign = ContentAlignment.MiddleCenter;
            // commentsTitle4
            commentsTitle4.Name = "commentsTitle4";
            commentsTitle4.Location = new Point(28, 25);
            commentsTitle4.Size = new Size(924, 38);
            commentsTitle4.Text = "Faculty Member Comments";
            commentsTitle4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            commentsTitle4.ForeColor = Color.FromArgb(30, 35, 40);
            // txtFacultyComments
            txtFacultyComments.Name = "txtFacultyComments";
            txtFacultyComments.Location = new Point(28, 78);
            txtFacultyComments.Size = new Size(924, 990);
            txtFacultyComments.Multiline = true;
            txtFacultyComments.AcceptsReturn = true;
            txtFacultyComments.ScrollBars = ScrollBars.Vertical;
            txtFacultyComments.Font = new Font("Segoe UI", 11F);
            txtFacultyComments.BorderStyle = BorderStyle.FixedSingle;
            // page4FormCode
            page4FormCode.Name = "page4FormCode";
            page4FormCode.Location = new Point(28, 1090);
            page4FormCode.Size = new Size(924, 20);
            page4FormCode.Text = "FSD21001";
            page4FormCode.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            page4FormCode.ForeColor = Color.FromArgb(30, 35, 40);
            // page4Footer
            page4Footer.Name = "page4Footer";
            page4Footer.Location = new Point(28, 1110);
            page4Footer.Size = new Size(924, 25);
            page4Footer.Text = "PAGE 4 of 5";
            page4Footer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            page4Footer.ForeColor = Color.FromArgb(30, 35, 40);
            page4FormCode.TextAlign = ContentAlignment.MiddleRight;
            page4Footer.TextAlign = ContentAlignment.MiddleCenter;
            // commentsTitle5
            commentsTitle5.Name = "commentsTitle5";
            commentsTitle5.Location = new Point(28, 25);
            commentsTitle5.Size = new Size(924, 38);
            commentsTitle5.Text = "Student Comments";
            commentsTitle5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            commentsTitle5.ForeColor = Color.FromArgb(30, 35, 40);
            // txtStudentComments
            txtStudentComments.Name = "txtStudentComments";
            txtStudentComments.Location = new Point(28, 78);
            txtStudentComments.Size = new Size(924, 990);
            txtStudentComments.Multiline = true;
            txtStudentComments.AcceptsReturn = true;
            txtStudentComments.ScrollBars = ScrollBars.Vertical;
            txtStudentComments.Font = new Font("Segoe UI", 11F);
            txtStudentComments.BorderStyle = BorderStyle.FixedSingle;
            // page5FormCode
            page5FormCode.Name = "page5FormCode";
            page5FormCode.Location = new Point(28, 1090);
            page5FormCode.Size = new Size(924, 20);
            page5FormCode.Text = "FSD21001";
            page5FormCode.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            page5FormCode.ForeColor = Color.FromArgb(30, 35, 40);
            // page5Footer
            page5Footer.Name = "page5Footer";
            page5Footer.Location = new Point(28, 1110);
            page5Footer.Size = new Size(924, 25);
            page5Footer.Text = "PAGE 5 of 5";
            page5Footer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            page5Footer.ForeColor = Color.FromArgb(30, 35, 40);
            page5FormCode.TextAlign = ContentAlignment.MiddleRight;
            page5Footer.TextAlign = ContentAlignment.MiddleCenter;
            toolbar.Controls.Add(recordIDLabel);
            toolbar.Controls.Add(txtRecordID);
            toolbar.Controls.Add(searchLabel);
            toolbar.Controls.Add(cmbSearchBy);
            toolbar.Controls.Add(txtSearch);
            toolbar.Controls.Add(btnSearch);
            toolbar.Controls.Add(btnNew);
            toolbar.Controls.Add(btnUpdate);
            toolbar.Controls.Add(btnSave);
            toolbar.Controls.Add(btnDelete);
            toolbar.Controls.Add(btnCancel);
            toolbar.Controls.Add(btnLogin);
            toolbar.Controls.Add(btnRegister);
            toolbar.Controls.Add(btnLogout);
            tabControl1.Controls.Add(tabPage1);
            tabPage1.Controls.Add(page1);
            tabControl1.Controls.Add(tabPage2);
            tabPage2.Controls.Add(page2);
            tabControl1.Controls.Add(tabPage3);
            tabPage3.Controls.Add(page3);
            tabControl1.Controls.Add(tabPage4);
            tabPage4.Controls.Add(page4);
            tabControl1.Controls.Add(tabPage5);
            tabPage5.Controls.Add(page5);
            page1.Controls.Add(osaLabel);
            page1.Controls.Add(txtOSA);
            page1.Controls.Add(university);
            page1.Controls.Add(address);
            page1.Controls.Add(policyTitle);
            page1.Controls.Add(caseTitle);
            page1.Controls.Add(printNote);
            page1.Controls.Add(stepOne);
            page1.Controls.Add(facultyInstructions);
            page1.Controls.Add(txtStudentNameLabel);
            page1.Controls.Add(txtStudentName);
            page1.Controls.Add(txtStudentIDLabel);
            page1.Controls.Add(txtStudentID);
            page1.Controls.Add(txtStudentEmailLabel);
            page1.Controls.Add(txtStudentEmail);
            page1.Controls.Add(txtFacultyNameLabel);
            page1.Controls.Add(txtFacultyName);
            page1.Controls.Add(txtCaseDateLabel);
            page1.Controls.Add(txtCaseDate);
            page1.Controls.Add(txtCourseNameLabel);
            page1.Controls.Add(txtCourseName);
            page1.Controls.Add(txtCourseNumberLabel);
            page1.Controls.Add(txtCourseNumber);
            page1.Controls.Add(txtAssignmentLabel);
            page1.Controls.Add(txtAssignment);
            page1.Controls.Add(txtDepartmentLabel);
            page1.Controls.Add(txtDepartment);
            page1.Controls.Add(txtTermIDLabel);
            page1.Controls.Add(txtTermID);
            page1.Controls.Add(txtViolationLabel);
            page1.Controls.Add(txtViolation);
            page1.Controls.Add(sanctionGuidance);
            page1.Controls.Add(txtSanctionsLabel);
            page1.Controls.Add(txtSanctions);
            page1.Controls.Add(chkSupportPerson);
            page1.Controls.Add(chkWrittenStatement);
            page1.Controls.Add(txtInitialFacultySignatureLabel);
            page1.Controls.Add(txtInitialFacultySignature);
            page1.Controls.Add(txtInitialFacultyNameLabel);
            page1.Controls.Add(txtInitialFacultyName);
            page1.Controls.Add(txtInitialFacultyDateLabel);
            page1.Controls.Add(txtInitialFacultyDate);
            page1.Controls.Add(page1FormCode);
            page1.Controls.Add(page1Footer);
            page2.Controls.Add(stepTwo);
            page2.Controls.Add(studentInstructions);
            page2.Controls.Add(txtAcknowledgedStudentLabel);
            page2.Controls.Add(txtAcknowledgedStudent);
            page2.Controls.Add(acknowledgmentText);
            page2.Controls.Add(grpStudentReview);
            grpStudentReview.Controls.Add(grpStudentReviewQuestion);
            grpStudentReview.Controls.Add(grpStudentReviewYes);
            grpStudentReview.Controls.Add(grpStudentReviewNo);
            page2.Controls.Add(studentCommentsNote);
            page2.Controls.Add(txtMyTRUEmailLabel);
            page2.Controls.Add(txtMyTRUEmail);
            page2.Controls.Add(txtStudentSignatureLabel);
            page2.Controls.Add(txtStudentSignature);
            page2.Controls.Add(txtStudentDateLabel);
            page2.Controls.Add(txtStudentDate);
            page2.Controls.Add(emailNote);
            page2.Controls.Add(stepThree);
            page2.Controls.Add(facultyFollowup);
            page2.Controls.Add(txtFollowupFacultySignatureLabel);
            page2.Controls.Add(txtFollowupFacultySignature);
            page2.Controls.Add(txtFollowupFacultyNameLabel);
            page2.Controls.Add(txtFollowupFacultyName);
            page2.Controls.Add(txtFollowupFacultyDateLabel);
            page2.Controls.Add(txtFollowupFacultyDate);
            page2.Controls.Add(page2FormCode);
            page2.Controls.Add(page2Footer);
            page3.Controls.Add(stepFour);
            page3.Controls.Add(chairInstructions);
            page3.Controls.Add(grpChairAgreement);
            grpChairAgreement.Controls.Add(grpChairAgreementQuestion);
            grpChairAgreement.Controls.Add(grpChairAgreementYes);
            grpChairAgreement.Controls.Add(grpChairAgreementNo);
            page3.Controls.Add(txtChairExplanationLabel);
            page3.Controls.Add(txtChairExplanation);
            page3.Controls.Add(txtChairCommentsLabel);
            page3.Controls.Add(txtChairComments);
            page3.Controls.Add(txtChairSignatureLabel);
            page3.Controls.Add(txtChairSignature);
            page3.Controls.Add(txtChairNameLabel);
            page3.Controls.Add(txtChairName);
            page3.Controls.Add(txtChairDateLabel);
            page3.Controls.Add(txtChairDate);
            page3.Controls.Add(stepFive);
            page3.Controls.Add(deanInstructions);
            page3.Controls.Add(grpDeanAgreement);
            grpDeanAgreement.Controls.Add(grpDeanAgreementQuestion);
            grpDeanAgreement.Controls.Add(grpDeanAgreementYes);
            grpDeanAgreement.Controls.Add(grpDeanAgreementNo);
            page3.Controls.Add(txtDeanExplanationLabel);
            page3.Controls.Add(txtDeanExplanation);
            page3.Controls.Add(txtDeanCommentsLabel);
            page3.Controls.Add(txtDeanComments);
            page3.Controls.Add(txtDeanSignatureLabel);
            page3.Controls.Add(txtDeanSignature);
            page3.Controls.Add(txtDeanNameLabel);
            page3.Controls.Add(txtDeanName);
            page3.Controls.Add(txtDeanDateLabel);
            page3.Controls.Add(txtDeanDate);
            page3.Controls.Add(page3FormCode);
            page3.Controls.Add(page3Footer);
            page4.Controls.Add(commentsTitle4);
            page4.Controls.Add(txtFacultyComments);
            page4.Controls.Add(page4FormCode);
            page4.Controls.Add(page4Footer);
            page5.Controls.Add(commentsTitle5);
            page5.Controls.Add(txtStudentComments);
            page5.Controls.Add(page5FormCode);
            page5.Controls.Add(page5Footer);
            this.Controls.Add(tabControl1);
            this.Controls.Add(toolbar);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 850);
            MinimumSize = new Size(1030, 620);
            Name = "Form1";
            Text = "Academic Integrity Policy ED 5-0 - Case Report Form";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            grpDeanAgreement.ResumeLayout(false);
            grpDeanAgreement.PerformLayout();
            grpChairAgreement.ResumeLayout(false);
            grpChairAgreement.PerformLayout();
            grpStudentReview.ResumeLayout(false);
            grpStudentReview.PerformLayout();
            page5.ResumeLayout(false);
            page5.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            page4.ResumeLayout(false);
            page4.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            page3.ResumeLayout(false);
            page3.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            page2.ResumeLayout(false);
            page2.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            page1.ResumeLayout(false);
            page1.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabControl1.PerformLayout();
            toolbar.ResumeLayout(false);
            toolbar.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private Panel toolbar = null!;
        private Label recordIDLabel = null!;
        private TextBox txtRecordID = null!;
        private Label searchLabel = null!;
        private ComboBox cmbSearchBy = null!;
        private TextBox txtSearch = null!;
        private Button btnSearch = null!;
        private Button btnNew = null!;
        private Button btnUpdate = null!;
        private Button btnSave = null!;
        private Button btnDelete = null!;
        private Button btnCancel = null!;
        private Button btnLogin = null!;
        private Button btnRegister = null!;
        private Button btnLogout = null!;
        private TabControl tabControl1 = null!;
        private TabPage tabPage1 = null!;
        private Panel page1 = null!;
        private TabPage tabPage2 = null!;
        private Panel page2 = null!;
        private TabPage tabPage3 = null!;
        private Panel page3 = null!;
        private TabPage tabPage4 = null!;
        private Panel page4 = null!;
        private TabPage tabPage5 = null!;
        private Panel page5 = null!;
        private Label osaLabel = null!;
        private TextBox txtOSA = null!;
        private Label university = null!;
        private Label address = null!;
        private Label policyTitle = null!;
        private Label caseTitle = null!;
        private Label printNote = null!;
        private Label stepOne = null!;
        private Label facultyInstructions = null!;
        private Label txtStudentNameLabel = null!;
        private TextBox txtStudentName = null!;
        private Label txtStudentIDLabel = null!;
        private TextBox txtStudentID = null!;
        private Label txtStudentEmailLabel = null!;
        private TextBox txtStudentEmail = null!;
        private Label txtFacultyNameLabel = null!;
        private TextBox txtFacultyName = null!;
        private Label txtCaseDateLabel = null!;
        private TextBox txtCaseDate = null!;
        private Label txtCourseNameLabel = null!;
        private TextBox txtCourseName = null!;
        private Label txtCourseNumberLabel = null!;
        private TextBox txtCourseNumber = null!;
        private Label txtAssignmentLabel = null!;
        private TextBox txtAssignment = null!;
        private Label txtDepartmentLabel = null!;
        private TextBox txtDepartment = null!;
        private Label txtTermIDLabel = null!;
        private TextBox txtTermID = null!;
        private Label txtViolationLabel = null!;
        private TextBox txtViolation = null!;
        private Label sanctionGuidance = null!;
        private Label txtSanctionsLabel = null!;
        private TextBox txtSanctions = null!;
        private CheckBox chkSupportPerson = null!;
        private CheckBox chkWrittenStatement = null!;
        private Label txtInitialFacultySignatureLabel = null!;
        private TextBox txtInitialFacultySignature = null!;
        private Label txtInitialFacultyNameLabel = null!;
        private TextBox txtInitialFacultyName = null!;
        private Label txtInitialFacultyDateLabel = null!;
        private TextBox txtInitialFacultyDate = null!;
        private Label page1FormCode = null!;
        private Label page1Footer = null!;
        private Label stepTwo = null!;
        private Label studentInstructions = null!;
        private Label txtAcknowledgedStudentLabel = null!;
        private TextBox txtAcknowledgedStudent = null!;
        private Label acknowledgmentText = null!;
        private Panel grpStudentReview = null!;
        private Label grpStudentReviewQuestion = null!;
        private RadioButton grpStudentReviewYes = null!;
        private RadioButton grpStudentReviewNo = null!;
        private Label studentCommentsNote = null!;
        private Label txtMyTRUEmailLabel = null!;
        private TextBox txtMyTRUEmail = null!;
        private Label txtStudentSignatureLabel = null!;
        private TextBox txtStudentSignature = null!;
        private Label txtStudentDateLabel = null!;
        private TextBox txtStudentDate = null!;
        private Label emailNote = null!;
        private Label stepThree = null!;
        private Label facultyFollowup = null!;
        private Label txtFollowupFacultySignatureLabel = null!;
        private TextBox txtFollowupFacultySignature = null!;
        private Label txtFollowupFacultyNameLabel = null!;
        private TextBox txtFollowupFacultyName = null!;
        private Label txtFollowupFacultyDateLabel = null!;
        private TextBox txtFollowupFacultyDate = null!;
        private Label page2FormCode = null!;
        private Label page2Footer = null!;
        private Label stepFour = null!;
        private Label chairInstructions = null!;
        private Panel grpChairAgreement = null!;
        private Label grpChairAgreementQuestion = null!;
        private RadioButton grpChairAgreementYes = null!;
        private RadioButton grpChairAgreementNo = null!;
        private Label txtChairExplanationLabel = null!;
        private TextBox txtChairExplanation = null!;
        private Label txtChairCommentsLabel = null!;
        private TextBox txtChairComments = null!;
        private Label txtChairSignatureLabel = null!;
        private TextBox txtChairSignature = null!;
        private Label txtChairNameLabel = null!;
        private TextBox txtChairName = null!;
        private Label txtChairDateLabel = null!;
        private TextBox txtChairDate = null!;
        private Label stepFive = null!;
        private Label deanInstructions = null!;
        private Panel grpDeanAgreement = null!;
        private Label grpDeanAgreementQuestion = null!;
        private RadioButton grpDeanAgreementYes = null!;
        private RadioButton grpDeanAgreementNo = null!;
        private Label txtDeanExplanationLabel = null!;
        private TextBox txtDeanExplanation = null!;
        private Label txtDeanCommentsLabel = null!;
        private TextBox txtDeanComments = null!;
        private Label txtDeanSignatureLabel = null!;
        private TextBox txtDeanSignature = null!;
        private Label txtDeanNameLabel = null!;
        private TextBox txtDeanName = null!;
        private Label txtDeanDateLabel = null!;
        private TextBox txtDeanDate = null!;
        private Label page3FormCode = null!;
        private Label page3Footer = null!;
        private Label commentsTitle4 = null!;
        private TextBox txtFacultyComments = null!;
        private Label page4FormCode = null!;
        private Label page4Footer = null!;
        private Label commentsTitle5 = null!;
        private TextBox txtStudentComments = null!;
        private Label page5FormCode = null!;
        private Label page5Footer = null!;
    }
}

