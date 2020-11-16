import { Injectable } from '@angular/core';
import { Note } from './note.model';

@Injectable({
  providedIn: 'root'
})
export class NotesServiceService {

  notes: Note[] = new Array<Note>();
  constructor() { }

  getAllNotes()
  {
    //Returns all the notes
    return this.notes;
  }

  getNote(id: number)
  {
    // Returns the Id of the note
    return this.notes[id];
  }

  getId(note : Note)
  {
    // Returns index of the note i.e id
    return this.notes.indexOf(note);
  }

  addNote(note: Note)
  {
    let newLenght = this.notes.push(note);
    let index = newLenght - 1;

    return index;
  }

  updateNote(id: number, title: string, body: string)
  {
    //Update the existing note
    let note = this.notes[id];
    note.title = title;
    note.body = body;
  }

  deleteNote(id: number)
  {
    // Delete the note
    this.notes.splice(id, 1);
  }
}
