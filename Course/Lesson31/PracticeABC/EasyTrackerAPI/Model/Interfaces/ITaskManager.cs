public interface ITaskManager
{
    List<TrackerTask> GetAllTasks();
    TrackerTask GetTaskById(int taskId);
    void AddTask(TrackerTask task);
    void DeleteTask(int taskId);
}