import { useQuery } from "@tanstack/react-query";
import "./App.css";
import NewTodoItem from "./components/NewTodoItem";
import TodoList from "./pages/TodoList";
import { Todo } from "./model/Todos";
import axios from "axios";
import React from "react";

const fetchTodos = async (): Promise<Todo[]> => {
  const res = await axios.get("https://localhost:7107/api/Todos");
  return res.data;
};

function App() {
  const [todoTitle, setTodoTitle] = React.useState<string>("");

  const { isLoading, error, data } = useQuery<Todo[]>({
    queryKey: ["todos"],
    queryFn: fetchTodos,
  });

  function createTodo() {
    if (!todoTitle) return;

    axios
      .post("https://localhost:7107/api/Todos", {
        title: todoTitle,
        completed: false,
        untilDate: new Date(),
      })
      .then(() => {
        setTodoTitle("");
        window.location.reload();
      });

    console.log(todoTitle);
  }

  if (isLoading) {
    return <div>Loading...</div>;
  }

  if (error) {
    return <div>Error: {error.message}</div>;
  }

  return (
    <div className="main">
      <h1>Todo List</h1>
      <NewTodoItem
        todoTitle={todoTitle}
        setTodoTitle={setTodoTitle}
        createTodo={createTodo}
      />
      {data && <TodoList todos={data} />}
    </div>
  );
}

export default App;
