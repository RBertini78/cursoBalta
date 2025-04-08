import { Component, NgModule } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CommonModule, JsonPipe } from '@angular/common';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { Todo } from '../models/todo.model';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule,ReactiveFormsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',

})

export class AppComponent {
  public mode = 'list';
  public title: String = 'Minhas Tarefas';
  public todos: Todo[] = [];
  public form: FormGroup;

  constructor(private fb: FormBuilder){
    this.form = this.fb.group({
      title:['', Validators.compose([
        Validators.minLength(3),
        Validators.maxLength(60),
        Validators.required
      ])]
    })
    this.load();
    // this.todos.push(new Todo(1,'Passear com o cachorro', false));
    // this.todos.push(new Todo(2, 'Ir ao supermercado', true));
    // this.todos.push(new Todo(3, 'Cortar o cabelo', false));
  }

  add() {
    //this.form.value => { title: 'Titulo'};
    const title = this.form.controls['title'].value;
    const id = this.todos.length + 1;
    this.todos.push(new Todo(id, title, false));
    this.save();
    this.clear();
  }

  clear() {
    this.form.reset();
  }

  remove(todo: Todo){
    const index = this.todos.indexOf(todo);
    if(index !== -1) {
      this.todos.splice(index, 1);
    }
    this.save();
  }

  maskAsDone(todo: Todo){
    todo.done = true;
    this.save();
  }

  markAsUndone(todo: Todo){
    todo.done = false;
    this.save();
  }

  save() {
    const data = JSON.stringify(this.todos);
    localStorage.setItem('todos', data);
    this.mode='list';
  }

  load() {
    const data = localStorage.getItem('todos');
    this.todos = data ? JSON.parse(data): [];
  }

  changeMode(mode:string) {
    this.mode = mode;
  }
}
