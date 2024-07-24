import React from "react";

export interface NewTodoItemProps {
  todoTitle: string;
  setTodoTitle: React.Dispatch<React.SetStateAction<string>>;
  createTodo: () => void;
}

function NewTodoItem({
  todoTitle,
  setTodoTitle,
  createTodo,
}: NewTodoItemProps) {
  return (
    <div className="new-todo">
      <input
        type="text"
        value={todoTitle}
        onChange={(e) => setTodoTitle(e.target.value)}
        placeholder="What needs to be done?"
      />
      <button onClick={createTodo}>
        <svg xmlns="http://www.w3.org/2000/svg">
          <path d="M8 4a.5.5 0 0 1 .5.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3A.5.5 0 0 1 8 4z" />
        </svg>
        <span>Add</span>
      </button>
    </div>
  );
}

export default NewTodoItem;
