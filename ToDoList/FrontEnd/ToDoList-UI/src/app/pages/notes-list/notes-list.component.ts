import { Component, OnInit } from '@angular/core';
import { Note } from 'src/app/shared/note.model';
import { NotesServiceService } from 'src/app/shared/notes-service.service';

@Component({
  selector: 'app-notes-list',
  templateUrl: './notes-list.component.html',
  styleUrls: ['./notes-list.component.scss']
})
export class NotesListComponent implements OnInit {

  notes: Note[] = new Array<Note>();
  constructor(private noteService: NotesServiceService) { }

  ngOnInit() {
    this.notes = this.noteService.getAllNotes();
  }

  deleteNote(id: number)
  {
    this.noteService.deleteNote(id);
  }

}
