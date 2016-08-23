using Praktikum1_Buku_1472006.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Praktikum1_Buku_1472006.Controllers
{
    public class DaftarBukuController : ApiController
    {
        private readonly AppDataContext _dataContext = new AppDataContext();

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_dataContext.DaftarBuku);
        }

        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            return Ok(_dataContext.DaftarBuku.Find(id));
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody]Book buku)
        {
            //buku.ISBN = Guid.NewGuid().ToString("N");
            _dataContext.DaftarBuku.Add(buku);
            _dataContext.SaveChanges();
            return Ok(buku);
        }

        [HttpPut]
        public IHttpActionResult Put(string id, [FromBody]Book buku)
        {
            var item = _dataContext.DaftarBuku.Find(id);
            if (item == null)
            {
                return BadRequest();
                //return null;
            }
            //item.ISBN = buku.ISBN;
            item.Author = buku.Author;
            item.Publisher = buku.Publisher;
            item.Title = buku.Title;
            item.Year = buku.Year;

            _dataContext.SaveChanges();

            return Ok(item);
        }
        [HttpDelete]
        public IHttpActionResult Delete(string id)
        {

            var item = _dataContext.DaftarBuku.Find(id);
            if (item == null)
            {
                // return null;
                return NotFound();
            }
            item.Deleted = true;
            //item.Jumlah = obat.Jumlah;
            //item.Harga = obat.Harga;

            _dataContext.SaveChanges();

            // return item;
            return Ok(item);
        }



        //Dispose buat ketika controller ngga dipake koneksi ke databse nya bakal keputus
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
