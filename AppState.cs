using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;

public class AppState
{
    private BehaviorSubject<TodoItem> currentTask = new BehaviorSubject<TodoItem>(null);
    public IObservable<TodoItem> CurrentTask => currentTask.AsObservable<TodoItem>();

    public void UpdateCurrentTask(TodoItem newCurrentTask)
    {
        currentTask.OnNext(newCurrentTask);
    }
}