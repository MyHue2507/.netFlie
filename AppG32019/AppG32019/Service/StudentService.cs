using AppG32019.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG32019.Service
{
    public class StudentService
    {
        /// <summary>
        /// Lấy thông tin sinh viên dựa vào mã sinh viên
        /// </summary>
        /// <param name="idStudent">Mã sinh viên</param>
        /// <returns>Thông tin của sinh viên có mã tương ứng.
        /// Nếu sinh viên không tồn tại thì trả về NULL
        /// </returns>
        public static Student GetStudent(string idStudent)
        {
            var student = new Student
            {
                Id = idStudent,
                FirstName = "Huệ",
                LastName = "Mỹ",
                DateOfBirth = new DateTime(1998, 10, 10),
                Gender = GENDER.Female,
                PlaceOfBirth = "Thừa Thiên Huế"
            };
            return student;
        }

        /// <summary>
        /// Lấy thông tin sinh viên thông qua file dữ liệu student.husc
        /// </summary>
        /// <param name="pathData">Đường dẫn của file student.husc</param>
        /// <param name="idStudent">Mã sinh viên cần lấy</param>
        /// <returns>Sinh viên có mã tương ứng</returns>
        public static Student GetStudent(string pathData, string idStudent)
        {
            if (File.Exists(pathData))
            {
                var lines = File.ReadAllLines(pathData);
                foreach (var line in lines)
                {
                    //line có cấu trúc:
                    //msv#ho#ten#ngaysinh#gioitinh#noisinh
                    var listItem = line.Split(new char[] { '#' });
                    Student student = new Student
                    {
                        Id = listItem[0],
                        LastName = listItem[1],
                        FirstName = listItem[2],
                        DateOfBirth =
                        DateTime.ParseExact(listItem[3], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Gender = listItem[4] == "male" ? GENDER.Male :
                            (listItem[4] == "female" ? GENDER.Female : GENDER.Other),
                        PlaceOfBirth = listItem[5]
                    };


                    if (student.Id == idStudent)
                        return student;
                }
                return null;
            }
            else
                return null;
        }
    }
}
