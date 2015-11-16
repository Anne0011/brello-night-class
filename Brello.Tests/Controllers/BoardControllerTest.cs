using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brello.Controllers;
using System.Web.Mvc;
using Brello.Models;
using Moq;

namespace Brello.Tests.Controllers
{
    
    [TestClass]
    public class BoardControllerTest
    {
        private Mock<BoardContext> mock_context;
        private Mock<BoardRepository> mock_repository;
        private ViewResult result;

        [TestInitialize]
        public void Initilaize()
        {
            mock_context = new Mock<BoardContext>();
            mock_repository = new Mock<BoardRepository> { };
            owner = new ApplicationUser();
            user1 = new ApplicationUser();
            user2 = new ApplicationUser();
        }

        [TestMethod]
        public void TBoardControllerEnsureIndexPageExits()
        {
            //Arrange
            BoardController controller = new BoardController();
            //Act
            ViewResult result = controller.Index() as ViewResult;
            //Assert
            Assert.IsNotNull(result);
  


        }
        [TestMethod]
        public void BoardControllerEnsureIndexViewExists()
        {
            //Arrange
            BoardController controller = new BoardController();
            //Act
            ViewResult result = controller.Index() as ViewResult;
            //Assert
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void BoardControllerItHasThings()
        {
            //Arrange
            BoardController controller = new BoardController();
            //Act
            ViewResult result = controller.Index() as ViewResult;
            //Assert
            string expected_message = "My Boards";
            Assert.AreEqual(expected_message, result.ViewBag.Message);
        }
        [TestMethod]
        public void BoardControllerEnsureListOfUserBoards()
        {
            //Arrange
            List<Board> my_boards = new List<Board>
            {
                new Board {Title = "My Awesome Board", BoardId = 1, Owner = owner },
                new Board {Title = "My Grocery Board", BoardId = 2, Owner = owner },
            };
            BoardController controller = new BoardController(mock_repository.Object);
            {
                mock_repository.Setup< r => r.GetAllBoards()>
            };
            //Act
            ViewResult result = controller.Index() as ViewResult;
            //Assert
            CollectionAssert.AreEqual(my_boards, result.ViewBag.Boards);
            
    }

    }
}
