using SchoolManagerProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagerProject.Data.Services
{
    //Contract for interacting with the data related to the Actor model
    public interface IActorsService
    {
        //Get all data from database
        //IEnumerable allows us to iterate through the data.
         Task<IEnumerable<Actor>> GetAll();

        //Get data by id from database
        Actor GetById(int id);

        //Add data to database
        void Add(Actor actor);

        //Update data to database
        Actor Update(int id, Actor newActor);

        //Delete data from database
        void Delete(int id);
    }
}
