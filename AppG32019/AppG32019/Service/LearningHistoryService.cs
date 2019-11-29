using AppG32019.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG32019.Service
{
    public class LearningHistoryService
    {
        /// <summary>
        /// Lấy danh sách quá trình học tập của 1 sinh viên
        /// </summary>
        /// <param name="idStudent">Mã sinh viên</param>
        /// <returns>Danh sách quá trình học tập</returns>
        public static List<LearningHistory> GetList(string idStudent)
        {
            List<LearningHistory> rs = new List<LearningHistory>();
            for (int i = 1; i <= 12; i++)
            {
                LearningHistory learning = new LearningHistory
                {
                    Id = i.ToString(),
                    YearFrom = 2007 + i,
                    YearEnd = 2008 + i,
                    IdStudent = idStudent
                };
                if (i <= 5)
                    learning.Address = "Tiểu học Phan Bội Châu";
                else if (i <= 9)
                    learning.Address = "Trung học Phan Đăng Lưu";
                else
                    learning.Address = "Phổ Thông Quốc học";
                rs.Add(learning);
            }
            return rs;
        }

        public static List<LearningHistory> GetListFromFile(string path, string idStudent)
        {
            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                //Mã#Từ năm#Đến năm#Nơi học#Mã sinh viên
                List<LearningHistory> rs = new List<LearningHistory>();
                foreach(var line in lines)
                {
                    //line = Mã#Từ năm#Đến năm#Nơi học#Mã sinh viên
                    var items = line.Split(new char[] { '#' });
                    LearningHistory history = new LearningHistory
                    {
                        Id = items[0],
                        YearFrom = int.Parse(items[1]),
                        YearEnd = int.Parse(items[2]),
                        Address = items[3],
                        IdStudent = items[4]
                    };
                    if (history.IdStudent == idStudent)
                        rs.Add(history);
                }
                return rs;
            }
            else
                return null;
        }

        public static void Delete(string path, string idHistory)
        {
            if(File.Exists(path)){
                var lines = File.ReadAllLines(path);
                File.WriteAllText(path,"");
                foreach( var line in lines){
                    var end = "";
                    if(line == lines[lines.Length-1]){
                        end = "" ;
                    }
                    else{
                        end = "\n";
                    }
                    var items = line.Split(new char[] { '#' });
                    if(items[0] != idHistory){
                        File.AppendAllText(path,line + end);////Append là thêm vào, chèn vào sau chuỗi có trước
                    }
                }
            }
        }

        public static void Add(string path, LearningHistory history)
        {
            if(File.Exists(path)){
                string line = history.Id + "#" + history.YearFrom + "#" + history.YearEnd + "#" + history.Address + "#" + history.IdStudent;
                File.AppendAllText(path,"\n" + line);
            }
        }

        public static void Update(string path, LearningHistory history)
        {
            if(File.Exists(path)){
                var lines = File.ReadAllLines(path);
                File.WriteAllText(path,"");
                foreach( var line in lines){
                    var end = "";
                    if(line == lines[lines.Length-1]){
                        end = "" ;
                    }
                    else{
                        end = "\n";
                    }
                    var items = line.Split(new char[] { '#' });
                    if(items[0] != history.Id){
                        File.AppendAllText(path,line + end);////Append là thêm vào, chèn vào sau chuỗi có trước
                    }
                    else{
                         string lineEdit = history.Id + "#" + history.YearFrom + "#" + history.YearEnd + "#" + history.Address + "#" + history.IdStudent;
                         File.AppendAllText(path,lineEdit + end);
                    }
                }
            }
        }
    }
}
