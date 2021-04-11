using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherAttendance_withDB.libraries;
using System.Windows.Forms;

namespace TeacherAttendance_withDB
{
    public partial class TeacherAttendace : Form
    {
        DataTable courseDT = DbOperations.getAllCourses();
        DataTable teacherDT = DbOperations.getAllTeachers();
        DataTable roomDT = DbOperations.getAllRooms();
        string id = "";

        public TeacherAttendace()
        {
            InitializeComponent();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            DataRow teacherDR = teacherDT.Rows[cBTeacher.Items.IndexOf(cBTeacher.SelectedItem.ToString())];
            DataRow roomDR = roomDT.Rows[cBRoom.Items.IndexOf(cBRoom.SelectedItem.ToString())];
            DataRow courseDR = courseDT.Rows[cBCourse.Items.IndexOf(cBCourse.SelectedItem.ToString())];
            DbOperations.createAttendant(dTPDate.Value.ToString() , dTPStartTime.Value.ToString() , dTPLeaveTime.Value.ToString() , teacherDR[0].ToString() , courseDR[0].ToString(), roomDR[0].ToString() , tBComment.Text);
            dGVAttendacnce.DataSource = DbOperations.getAllAttendance();
        }

        private void TeacherAttendace_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in courseDT.Rows)
            {
                cBCourse.Items.Add(dr[1]);
            }
            foreach (DataRow dr in teacherDT.Rows)
            {
                cBTeacher.Items.Add(dr[1]);
            }
            foreach (DataRow dr in roomDT.Rows)
            {
                cBRoom.Items.Add(dr[1]);
            }
            dGVAttendacnce.DataSource = DbOperations.getAllAttendance();
        }
    }
}
