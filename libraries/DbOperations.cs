using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherAttendance_withDB.libraries
{
    class DbOperations
    {
        public static DataTable getAllCourses()
        {

            DbCommand comm = DatabaseConnection.getConnection();
            comm.CommandText = "SELECT id as ID , name as 'Course Name' FROM course";
            DataTable table;
            try
            {
                comm.Connection.Open();
                DbDataReader reader = comm.ExecuteReader();
                table = new DataTable();
                table.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                comm.Connection.Close();
            }
            return table;
        }

        public static DataTable getAllTeachers()
        {

            DbCommand comm = DatabaseConnection.getConnection();
            comm.CommandText = "SELECT id as ID , name as 'Teacher Name' FROM teacher";
            DataTable table;
            try
            {
                comm.Connection.Open();
                DbDataReader reader = comm.ExecuteReader();
                table = new DataTable();
                table.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                comm.Connection.Close();
            }
            return table;
        }

        public static DataTable getAllRooms()
        {

            DbCommand comm = DatabaseConnection.getConnection();
            comm.CommandText = "SELECT id as ID , name as 'Room Name' FROM room";
            DataTable table;
            try
            {
                comm.Connection.Open();
                DbDataReader reader = comm.ExecuteReader();
                table = new DataTable();
                table.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                comm.Connection.Close();
            }
            return table;
        }

        public static DataTable getAllAttendance()
        {

            DbCommand comm = DatabaseConnection.getConnection();
            comm.CommandText = "SELECT attendance.id as ID , Date as Date , start_time as 'Start Time' , leave_time as 'Leave Time'  ,course.name as 'Course Name' , teacher.name as 'Teacher Name'  , room.name as 'Room Name' , comment as Comment FROM attendance , course ,teacher , room Where attendance.course_id = course.id AND attendance.teacher_id=teacher.id AND attendance.room_id = room.id";
            DataTable table;
            try
            {
                comm.Connection.Open();
                DbDataReader reader = comm.ExecuteReader();
                table = new DataTable();
                table.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                comm.Connection.Close();
            }
            return table;
        }


        public static void createAttendant(string date, string startTime, string leaveTime, string teacherId, string roomId, string courseId,string comment)
        {
            DbCommand comm = DatabaseConnection.getConnection();
            String Sql = "INSERT INTO attendance ";
            Sql += "(Date, start_time, leave_time, teacher_id, room_id , course_id , comment) ";
            Sql += "VALUES ('" + date + "','" + startTime + "','" + leaveTime + "',";
            Sql += teacherId + "," + roomId + "," + courseId + ",'" + comment + "')";
            comm.CommandText = Sql;

            int affectedRows = -1;
            try
            {
                comm.Connection.Open();
                affectedRows = comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                comm.Connection.Close();
            }

        }


    }
}
