﻿using NotelyRestApi.Database;
using NotelyRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotelyRestApi.Repositories.Implementations
{
    public class NoteRepository : INoteRepository
    {
        private NotelyDbContext _context;
        private Note noteModel;

        public NoteRepository(NotelyDbContext context)
        {
            _context = context;
        } 

        public Note FindNoteById(long id)
        {
            var note = _context.Notes.Find(id);
            return note;
        }

        public IEnumerable<Note> GetAllNotes ()
        {
            var notes = _context.Notes;
            return notes;
            }
        

        public void SaveNote(Note note)
        {
            _context.Notes.Add(note);
            _context.SaveChanges();
        }

        public void EditNote(Note note)
        {
            _context.Notes.Remove(noteModel);
            _context.SaveChanges();
        }

        public void DeleteNote(Note noteModel)
        {
            _context.Notes.Remove(noteModel);
            _context.SaveChanges();
        }
    }
}
