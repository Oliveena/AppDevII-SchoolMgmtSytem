namespace SchoolManagementSystem.Patterns.Observer
{
    using Models.Grades;
    using System.Collections.Generic;

        public class GradeSubject
        {
            private readonly List<IGradeObserver> _observers = new();

            public void Attach(IGradeObserver observer)
            {
                _observers.Add(observer);
            }

            public void Detach(IGradeObserver observer)
            {
                _observers.Remove(observer);
            }

            public void Notify(Grade grade)
            {
                foreach (var observer in _observers)
                {
                    observer.Update(grade);
                }
            }
        }
    }
