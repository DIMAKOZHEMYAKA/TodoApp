using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO.Pipelines;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace TodoApp.module
{
    public class TaskManager
    {
        private readonly List<TaskItem> _tasklist;

        public TaskManager()
        {
            _tasklist = new List<TaskItem>();
        }

        public TaskManager(List<TaskItem> tasklist)
        {
            _tasklist = tasklist;
        }

        public void AddTask(string title, string description)
        {
            _tasklist.Add(new TaskItem(_tasklist.Count(), title, description));
        }

        public void RemoveTasks(IEnumerable<int> ids)
        {
            var idSet = ids as HashSet<int> ?? [.. ids];
            _tasklist.RemoveAll(n => idSet.Contains(n.Id));

            //После удаления нужна сортировка и переопределение индексов

            System.Console.WriteLine($"Убиу");
        }

        public ImmutableList<TaskItem> GetAllTasks()
        {
            return _tasklist.ToImmutableList();
        }
        public List<TaskItem> GetPendingTasks()
        {
            return _tasklist
            .Where(n => !n.IsCompleted)
            .ToList();

        }

        public List<TaskItem> GetCompletedTasks()
        {
            return _tasklist
            .Where(n => n.IsCompleted)
            .ToList();
        }



        public override string ToString()
        {
            if (_tasklist is null || _tasklist.Count == 0)
            {
                return "Перекати поле";
            }
            return string.Join("\n", _tasklist);
        }
    }
}