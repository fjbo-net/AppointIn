using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Data;
using AppointIn.Domain.Entities;

namespace AppointIn.TestDataSeed
{
	public static partial class DataInitializer
	{
		public static ICollection<Customer> GenerateCustomers()
		{
			var output = new List<Customer>()
			{
				new Customer() { Id = 1, Name = "Alfreds Futterkiste", Address = UnitOfWork.Data.Addresses.GetById(1), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 2, Name = "Ana Trujillo Emparedados y helados", Address = UnitOfWork.Data.Addresses.GetById(2), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 3, Name = "Antonio Moreno Taquería", Address = UnitOfWork.Data.Addresses.GetById(3), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 4, Name = "Around the Horn", Address = UnitOfWork.Data.Addresses.GetById(4), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 5, Name = "Berglunds snabbköp", Address = UnitOfWork.Data.Addresses.GetById(5), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 6, Name = "Blauer See Delikatessen", Address = UnitOfWork.Data.Addresses.GetById(6), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 7, Name = "Blondel père et fils", Address = UnitOfWork.Data.Addresses.GetById(7), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 8, Name = "Bólido Comidas preparadas", Address = UnitOfWork.Data.Addresses.GetById(8), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 9, Name = "Bon app", Address = UnitOfWork.Data.Addresses.GetById(9), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 10, Name = "Bottom-Dollar Marketse", Address = UnitOfWork.Data.Addresses.GetById(10), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 11, Name = "Bs Beverages", Address = UnitOfWork.Data.Addresses.GetById(11), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 12, Name = "Cactus Comidas para llevar", Address = UnitOfWork.Data.Addresses.GetById(12), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 13, Name = "Centro comercial Moctezuma", Address = UnitOfWork.Data.Addresses.GetById(13), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 14, Name = "Chop-suey Chinese", Address = UnitOfWork.Data.Addresses.GetById(14), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 15, Name = "Comércio Mineiro", Address = UnitOfWork.Data.Addresses.GetById(15), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 16, Name = "Consolidated Holdings", Address = UnitOfWork.Data.Addresses.GetById(16), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 17, Name = "Drachenblut Delikatessend", Address = UnitOfWork.Data.Addresses.GetById(17), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 18, Name = "Du monde entier", Address = UnitOfWork.Data.Addresses.GetById(18), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 19, Name = "Eastern Connection", Address = UnitOfWork.Data.Addresses.GetById(19), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 20, Name = "Ernst Handel", Address = UnitOfWork.Data.Addresses.GetById(20), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 21, Name = "Familia Arquibaldo", Address = UnitOfWork.Data.Addresses.GetById(21), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 22, Name = "FISSA Fabrica Inter. Salchichas S.A.", Address = UnitOfWork.Data.Addresses.GetById(22), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 23, Name = "Folies gourmandes", Address = UnitOfWork.Data.Addresses.GetById(23), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 24, Name = "Folk och fä HB", Address = UnitOfWork.Data.Addresses.GetById(24), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 25, Name = "Frankenversand", Address = UnitOfWork.Data.Addresses.GetById(25), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 26, Name = "France restauration", Address = UnitOfWork.Data.Addresses.GetById(26), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 27, Name = "Franchi S.p.A.", Address = UnitOfWork.Data.Addresses.GetById(27), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 28, Name = "Furia Bacalhau e Frutos do Mar", Address = UnitOfWork.Data.Addresses.GetById(28), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 29, Name = "Galería del gastrónomo", Address = UnitOfWork.Data.Addresses.GetById(29), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 30, Name = "Godos Cocina Típica", Address = UnitOfWork.Data.Addresses.GetById(30), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 31, Name = "Gourmet Lanchonetes", Address = UnitOfWork.Data.Addresses.GetById(31), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 32, Name = "Great Lakes Food Market", Address = UnitOfWork.Data.Addresses.GetById(32), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 33, Name = "GROSELLA-Restaurante", Address = UnitOfWork.Data.Addresses.GetById(33), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 34, Name = "Hanari Carnes", Address = UnitOfWork.Data.Addresses.GetById(34), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 35, Name = "HILARIÓN-Abastos", Address = UnitOfWork.Data.Addresses.GetById(35), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 36, Name = "Hungry Coyote Import Store", Address = UnitOfWork.Data.Addresses.GetById(36), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 37, Name = "Hungry Owl All-Night Grocers", Address = UnitOfWork.Data.Addresses.GetById(37), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 38, Name = "Island Trading", Address = UnitOfWork.Data.Addresses.GetById(38), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 39, Name = "Königlich Essen", Address = UnitOfWork.Data.Addresses.GetById(39), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 40, Name = "La corne dabondance", Address = UnitOfWork.Data.Addresses.GetById(40), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 41, Name = "La maison dAsie", Address = UnitOfWork.Data.Addresses.GetById(41), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 42, Name = "Laughing Bacchus Wine Cellars", Address = UnitOfWork.Data.Addresses.GetById(42), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 43, Name = "Lazy K Kountry Store", Address = UnitOfWork.Data.Addresses.GetById(43), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 44, Name = "Lehmanns Marktstand", Address = UnitOfWork.Data.Addresses.GetById(44), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 45, Name = "Lets Stop N Shop", Address = UnitOfWork.Data.Addresses.GetById(45), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 46, Name = "LILA-Supermercado", Address = UnitOfWork.Data.Addresses.GetById(46), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 47, Name = "LINO-Delicateses", Address = UnitOfWork.Data.Addresses.GetById(47), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 48, Name = "Lonesome Pine Restaurant", Address = UnitOfWork.Data.Addresses.GetById(48), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 49, Name = "Magazzini Alimentari Riuniti", Address = UnitOfWork.Data.Addresses.GetById(49), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 50, Name = "Maison Dewey", Address = UnitOfWork.Data.Addresses.GetById(50), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 51, Name = "Mère Paillarde", Address = UnitOfWork.Data.Addresses.GetById(51), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 52, Name = "Morgenstern Gesundkost", Address = UnitOfWork.Data.Addresses.GetById(52), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 53, Name = "North/South", Address = UnitOfWork.Data.Addresses.GetById(53), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 54, Name = "Océano Atlántico Ltda.", Address = UnitOfWork.Data.Addresses.GetById(54), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 55, Name = "Old World Delicatessen", Address = UnitOfWork.Data.Addresses.GetById(55), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 56, Name = "Ottilies Käseladen", Address = UnitOfWork.Data.Addresses.GetById(56), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 57, Name = "Paris spécialités", Address = UnitOfWork.Data.Addresses.GetById(57), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 58, Name = "Pericles Comidas clásicas", Address = UnitOfWork.Data.Addresses.GetById(58), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 59, Name = "Piccolo und mehr", Address = UnitOfWork.Data.Addresses.GetById(59), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 60, Name = "Princesa Isabel Vinhoss", Address = UnitOfWork.Data.Addresses.GetById(60), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 61, Name = "Que Delícia", Address = UnitOfWork.Data.Addresses.GetById(61), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 62, Name = "Queen Cozinha", Address = UnitOfWork.Data.Addresses.GetById(62), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 63, Name = "QUICK-Stop", Address = UnitOfWork.Data.Addresses.GetById(63), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 64, Name = "Rancho grande", Address = UnitOfWork.Data.Addresses.GetById(64), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 65, Name = "Rattlesnake Canyon Grocery", Address = UnitOfWork.Data.Addresses.GetById(65), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 66, Name = "Reggiani Caseifici", Address = UnitOfWork.Data.Addresses.GetById(66), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 67, Name = "Ricardo Adocicados", Address = UnitOfWork.Data.Addresses.GetById(67), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 68, Name = "Richter Supermarkt", Address = UnitOfWork.Data.Addresses.GetById(68), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 69, Name = "Romero y tomillo", Address = UnitOfWork.Data.Addresses.GetById(69), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 70, Name = "Santé Gourmet", Address = UnitOfWork.Data.Addresses.GetById(70), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 71, Name = "Save-a-lot Markets", Address = UnitOfWork.Data.Addresses.GetById(71), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 72, Name = "Seven Seas Imports", Address = UnitOfWork.Data.Addresses.GetById(72), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 73, Name = "Simons bistro", Address = UnitOfWork.Data.Addresses.GetById(73), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 74, Name = "Spécialités du monde", Address = UnitOfWork.Data.Addresses.GetById(74), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 75, Name = "Split Rail Beer & Ale", Address = UnitOfWork.Data.Addresses.GetById(75), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 76, Name = "Suprêmes délices", Address = UnitOfWork.Data.Addresses.GetById(76), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 77, Name = "The Big Cheese", Address = UnitOfWork.Data.Addresses.GetById(77), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 78, Name = "The Cracker Box", Address = UnitOfWork.Data.Addresses.GetById(78), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 79, Name = "Toms Spezialitäten", Address = UnitOfWork.Data.Addresses.GetById(79), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 80, Name = "Tortuga Restaurante", Address = UnitOfWork.Data.Addresses.GetById(80), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 81, Name = "Tradição Hipermercados", Address = UnitOfWork.Data.Addresses.GetById(81), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 82, Name = "Trails Head Gourmet Provisioners", Address = UnitOfWork.Data.Addresses.GetById(82), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 83, Name = "Vaffeljernet", Address = UnitOfWork.Data.Addresses.GetById(83), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 84, Name = "Victuailles en stock", Address = UnitOfWork.Data.Addresses.GetById(84), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 85, Name = "Vins et alcools Chevalier", Address = UnitOfWork.Data.Addresses.GetById(85), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 86, Name = "Die Wandernde Kuh", Address = UnitOfWork.Data.Addresses.GetById(86), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 87, Name = "Wartian Herkku", Address = UnitOfWork.Data.Addresses.GetById(87), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 88, Name = "Wellington Importadora", Address = UnitOfWork.Data.Addresses.GetById(88), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 89, Name = "White Clover Markets", Address = UnitOfWork.Data.Addresses.GetById(89), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 90, Name = "Wilman Kala", Address = UnitOfWork.Data.Addresses.GetById(90), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new Customer() { Id = 91, Name = "Wolski", Address = UnitOfWork.Data.Addresses.GetById(91), IsActive = true, CreateDate = DateTime.Now.ToUniversalTime(), CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" }
			};

			return output;
		}


		// Using lambda expression to simplify function definition due to simplicity
		public static bool DataBaseHasInitializedCustomers()
			=> UnitOfWork.Data.Customers.GetAll().Any();
	}
}
