export interface Todo {
  id: string;
  title: string;
  isCompleted: boolean;
  untilDate: Date;
}

export interface NewTodo {
  title: string;
  untilDate: Date;
}

export interface EditTodo {
  id: string;
  title: string;
  untilDate: Date;
  isCompleted: boolean;
}
