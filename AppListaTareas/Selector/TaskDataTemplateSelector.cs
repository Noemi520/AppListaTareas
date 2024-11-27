using AppListaTareas.MVVM.Model;

namespace AppListaTareas.Selector
{
    internal class TaskDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Task? task = item as Task;
            if (task != null && !task.HasPriority) 
            {
                Application.Current!.Resources.TryGetValue("TaskTemplate", out var taskStyle);
                return taskStyle as DataTemplate ?? new DataTemplate();
            }
            Application.Current!.Resources.TryGetValue("PriorityTaskTemplate", out var priorityStyle);
            return priorityStyle as DataTemplate ?? new DataTemplate();
        }
    }
}
