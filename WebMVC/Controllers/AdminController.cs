﻿using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Services;
using BusinessLayer.DTOs.Book;
using BusinessLayer.DTOs;
using BusinessLayer.DTOs.Genre;
using BusinessLayer.DTOs.Publisher;
using BusinessLayer.DTOs.PurchaseHistory;
using Microsoft.AspNetCore.Authorization;

namespace WebMVC.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        private readonly IBookService _bookService;
        private readonly ICustomerService _customerService;
        private readonly IGenreService _genreService;
        private readonly IPublisherService _publisherService;
        private readonly IPurchaseHistoryService _purchaseHistoryService;

        public AdminController(IBookService bookService, ICustomerService customerService,  IGenreService genreService, IPublisherService publisherService, IPurchaseHistoryService purchaseHistoryService)
        {
            _bookService = bookService;
            _customerService = customerService;
            _genreService = genreService;
            _publisherService = publisherService;
            _purchaseHistoryService = purchaseHistoryService;
        }

        [HttpGet("")]
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("edit-book/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditBook(int id)
        {
            var book = await _bookService.GetBookAsync(id);
            if (book == null) return NotFound();

            return View(book);
        }

        [HttpPost("edit-book/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditBook(int id, BookCreateUpdateDTO book)
        {
            await _bookService.UpdateBookAsync(id, book);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet("edit-customer/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditCustomer(int id)
        {
            var customer = await _customerService.GetCustomerAsync(id);
            if (customer == null) return NotFound();

            return View(customer);
        }

        [HttpPost("edit-customer/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditCustomer(int id, CustomerDTO customer)
        {
            await _customerService.UpdateCustomerAsync(id, customer);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet("edit-genre/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditGenre(int id)
        {
            var genre = await _genreService.GetGenreAsync(id);
            if (genre == null) return NotFound();

            return View(genre);
        }

        [HttpPost("edit-genre/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditGenre(int id, GenreCreateUpdateDTO genre)
        {
            await _genreService.UpdateGenreAsync(id, genre);
            return RedirectToAction("Index", "Admin");
        }

        [HttpGet("edit-publisher/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditPublisher(int id)
        {
            var publisher = await _publisherService.GetPublisherAsync(id);
            if (publisher == null) return NotFound();

            return View(publisher); // Create corresponding view
        }

        [HttpPost("edit-publisher/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditPublisher(int id, PublisherCreateUpdateDTO publisher)
        {
            await _publisherService.UpdatePublisherAsync(id, publisher);
            return RedirectToAction("Index", "Admin"); // or any other admin page
        }

        [HttpGet("edit-purchase-history/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditPurchaseHistory(int id)
        {
            var purchaseHistory = await _purchaseHistoryService.GetPurchaseHistoryAsync(id);
            if (purchaseHistory == null) return NotFound();

            return View(purchaseHistory); // Create corresponding view
        }

        [HttpPost("edit-purchase-history/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditPurchaseHistory(int id, PurchaseHistoryUpdateDTO model)
        {
            await _purchaseHistoryService.UpdatePurchaseHistoryAsync(id, model);
            return RedirectToAction("Index", "Admin"); // or any other admin page
        }
    }
}
