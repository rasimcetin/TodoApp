import { Todo } from "../model/Todos";
import TodoItem from "../components/TodoItem";

export interface TodoListProps {
  todos: Todo[];
}

function TodoList({ todos }: TodoListProps) {
  return (
    <div className="todo-list">
      <ul>
        {todos &&
          todos.map((todo) => (
            <li key={todo.id}>
              <TodoItem todo={todo} />
            </li>
          ))}
      </ul>
    </div>
  );
}

export default TodoList;
