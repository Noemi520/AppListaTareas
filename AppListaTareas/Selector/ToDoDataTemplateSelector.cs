
using AppListaTareas.MVVM.Model;

namespace AppListaTareas.Selector
{
    internal class ToDoDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            ToDo? toDo = item as ToDo;
            if (toDo is not null && !toDo.HasPriority) 
            {
                Application.Current!.Resources.TryGetValue("ToDoTemplate", out var ToDoStyle);
                return ToDoStyle as DataTemplate ?? new DataTemplate();
            }
            Application.Current!.Resources.TryGetValue("PriorityToDoTemplate", out var priorityStyle);
            return priorityStyle as DataTemplate ?? new DataTemplate();
        }
    }
}
