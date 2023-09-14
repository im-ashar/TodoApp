using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Database;
using TodoApp.Shared;

namespace TodoApp.Models
{
    /*public class Repository
    {
        public static List<TaskItem> GetTaskItems()
        {
            using var db = new AppDbContext();
            return db.TaskItems.ToList();
        }
        public static void AddTaskItem(TaskItem taskItem)
        {
            using var db = new AppDbContext();
            db.TaskItems.Add(taskItem);
            db.SaveChanges();
        }
        public static void DeleteTaskItem(TaskItem taskItem)
        {
            using var db = new AppDbContext();
            db.TaskItems.Remove(taskItem);
            db.SaveChanges();
        }
        public static void UpdateTaskItem(TaskItem taskItem)
        {
            using var db = new AppDbContext();
            db.TaskItems.Update(taskItem);
            db.SaveChanges();
        }
    }*/
}
