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
    <div className="new-todo-item">
      <input
        type="text"
        value={todoTitle}
        onChange={(e) => setTodoTitle(e.target.value)}
      />
      <button onClick={createTodo}>
        <svg
          xmlns="http://www.w3.org/2000/svg"
          viewBox="0 -960 960 960"
          fill="#5f6368"
        >
          <path d="M440-440H200v-80h240v-240h80v240h240v80H520v240h-80v-240Z" />
        </svg>
        Add
      </button>
    </div>
  );
}

export default NewTodoItem;
