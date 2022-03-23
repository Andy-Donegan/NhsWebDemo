using Microsoft.EntityFrameworkCore;
using NhsWebDemo.DataContext;
using Faker;
using System.ComponentModel;

namespace NhsWebDemo.Models
{
    public class NationalModelDataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new NhsDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<NhsDBContext>>()))
            {
#region LocalModel Generation
                // Create Local Model Data
                // Check for any records already in database.
                if (context.LocalModels.Any())
                {
                    return;   // Database has been seeded
                }
                context.LocalModels.AddRange(
                  new LocalModel(1, 1, "Cumbria"),
                  new LocalModel(2, 1, "Hambleton, Richmondshire and Whitby (with partners)"),
                  new LocalModel(3, 1, "Hartlepool and Stockton-on-Tees"),
                  new LocalModel(4, 1, "Newcastle Gateshead"),
                  new LocalModel(5, 1, "County Durham and Darlington"),
                  new LocalModel(6, 1, "Northumberland and North Tyneside"),
                  new LocalModel(7, 1, "South Tyneside and Sunderland"),
                  new LocalModel(8, 2, "Bradford District and Craven"),
                  new LocalModel(9, 2, "Calderdale"),
                  new LocalModel(10, 2, "Kirklees"),
                  new LocalModel(11, 2, "Leeds"),
                  new LocalModel(12, 2, "Wakefield"),
                  new LocalModel(13, 3, "East Riding"),
                  new LocalModel(14, 3, "Hull"),
                  new LocalModel(15, 3, "North Lincolnshire"),
                  new LocalModel(16, 3, "North East Lincolnshire"),
                  new LocalModel(17, 3, "North Yorkshire"),
                  new LocalModel(18, 3, "York"),
                  new LocalModel(19, 4, "Bassetlaw"),
                  new LocalModel(20, 4, "Doncaster"),
                  new LocalModel(21, 4, "Barnsley"),
                  new LocalModel(22, 4, "Rotherham"),
                  new LocalModel(23, 4, "Sheffield"),
                  new LocalModel(24, 5, "Blackburn With Darwen"),
                  new LocalModel(25, 5, "Blackpool"),
                  new LocalModel(26, 5, "Chorley and South Ribble"),
                  new LocalModel(27, 5, "East Lancashire"),
                  new LocalModel(28, 5, "Fylde and Wyre"),
                  new LocalModel(29, 5, "Greater Preston"),
                  new LocalModel(30, 5, "Lancashire North"),
                  new LocalModel(31, 5, "West Lancashire"),
                  new LocalModel(32, 6, "North Manchester"),
                  new LocalModel(33, 6, "Central Manchester"),
                  new LocalModel(34, 6, "South Manchester"),
                  new LocalModel(35, 7, "Cheshire"),
                  new LocalModel(36, 7, "Halton"),
                  new LocalModel(37, 7, "Knowsley"),
                  new LocalModel(38, 7, "Liverpool"),
                  new LocalModel(39, 7, "Southport and Formby"),
                  new LocalModel(40, 7, "South Sefton"),
                  new LocalModel(41, 7, "St Helens"),
                  new LocalModel(42, 7, "Warrington"),
                  new LocalModel(43, 7, "Wirral"),
                  new LocalModel(44, 8, "Cannock Chase"),
                  new LocalModel(45, 8, "East Staffordshire"),
                  new LocalModel(46, 8, "North Staffordshire"),
                  new LocalModel(47, 8, "South East Staffordshire and Seisdon Peninsula"),
                  new LocalModel(48, 8, "Stafford and Surrounds"),
                  new LocalModel(49, 8, "Soke-on-Trent"),
                  new LocalModel(50, 9, "Shropshire"),
                  new LocalModel(51, 9, "Telford"),
                  new LocalModel(52, 9, "Wrekin"),
                  new LocalModel(53, 10, "Derby"),
                  new LocalModel(54, 10, "North Derbyshire"),
                  new LocalModel(55, 10, "Southern Derbyshire"),
                  new LocalModel(56, 10, "Erewash"),
                  new LocalModel(57, 10, "Hardwick"),
                  new LocalModel(58, 11, "Lincolnshire East"),
                  new LocalModel(59, 11, "Lincolnshire West"),
                  new LocalModel(60, 11, "South West Lincolnshire"),
                  new LocalModel(61, 11, "South Lincolnshire"),
                  new LocalModel(62, 12, "Mansfield and Ashfield"),
                  new LocalModel(63, 12, "Newark and Sherwood"),
                  new LocalModel(64, 12, "Nottingham City"),
                  new LocalModel(65, 12, "Nottingham North and East"),
                  new LocalModel(66, 12, "Nottingham West"),
                  new LocalModel(67, 12, "Rushcliffe"),
                  new LocalModel(68, 13, "East Leicestershire and Rutland"),
                  new LocalModel(69, 13, "Leicester City"),
                  new LocalModel(70, 13, "West Leicestershire"),
                  new LocalModel(71, 14, "Black Country"),
                  new LocalModel(72, 14, "West Birmingham"),
                  new LocalModel(73, 15, "Birmingham"),
                  new LocalModel(74, 15, "Solihull"),
                  new LocalModel(75, 16, "Coventry"),
                  new LocalModel(76, 16, "Warwickshire"),
                  new LocalModel(77, 17, "Herefordshire"),
                  new LocalModel(78, 17, "Redditch and Bromsgrove"),
                  new LocalModel(79, 17, "South Worcestershire"),
                  new LocalModel(80, 17, "Wyre Forest"),
                  new LocalModel(81, 18, "Corby"),
                  new LocalModel(82, 18, "Nene"),
                  new LocalModel(83, 19, "Cambridgeshire"),
                  new LocalModel(84, 19, "Peterborough"),
                  new LocalModel(85, 20, "Norfolk"),
                  new LocalModel(86, 20, "Waveney"),
                  new LocalModel(87, 21, "West Suffolk"),
                  new LocalModel(88, 21, "North East Essex"),
                  new LocalModel(89, 21, "Ipswich and East Suffolk"),
                  new LocalModel(90, 22, "Bedfordshire"),
                  new LocalModel(91, 22, "Luton"),
                  new LocalModel(92, 22, "Milton Keynes"),
                  new LocalModel(93, 23, "Herts Valleys"),
                  new LocalModel(94, 23, "East and North Hertfordshire"),
                  new LocalModel(95, 23, "West Essex"),
                  new LocalModel(96, 24, "Basildon and Brentwood"),
                  new LocalModel(97, 24, "Southend"),
                  new LocalModel(98, 24, "Castlepoint and Rochford"),
                  new LocalModel(99, 24, "Mid Essex"),
                  new LocalModel(100, 24, "Thurrock"),
                  new LocalModel(101, 25, "Brent"),
                  new LocalModel(102, 25, "Ealing"),
                  new LocalModel(103, 25, "Harrow"),
                  new LocalModel(104, 25, "Hounslow"),
                  new LocalModel(105, 25, "Central London"),
                  new LocalModel(106, 25, "Hammersmith and Fulham"),
                  new LocalModel(107, 25, "Hillingdon"),
                  new LocalModel(108, 25, "West London"),
                  new LocalModel(109, 26, "Barnet"),
                  new LocalModel(110, 26, "Camden"),
                  new LocalModel(111, 26, "Enfield"),
                  new LocalModel(112, 26, "Haringey"),
                  new LocalModel(113, 26, "Islington"),
                  new LocalModel(114, 27, "City and Hackney"),
                  new LocalModel(115, 27, "Newham"),
                  new LocalModel(116, 27, "Tower Hamlets"),
                  new LocalModel(117, 27, "Waltham Forest"),
                  new LocalModel(118, 27, "Barking and Dagenham"),
                  new LocalModel(119, 27, "Havering and Redbridge"),
                  new LocalModel(120, 28, "Bexley"),
                  new LocalModel(121, 28, "Bromley"),
                  new LocalModel(122, 28, "Greenwich"),
                  new LocalModel(123, 28, "Lambeth"),
                  new LocalModel(124, 28, "Lewisham"),
                  new LocalModel(125, 28, "Southwark"),
                  new LocalModel(126, 29, "Croydon"),
                  new LocalModel(127, 29, "Kingston"),
                  new LocalModel(128, 29, "Merton"),
                  new LocalModel(129, 29, "Richmond"),
                  new LocalModel(130, 29, "Sutton"),
                  new LocalModel(131, 29, "Wandsworth"),
                  new LocalModel(132, 30, "Kent"),
                  new LocalModel(133, 30, "Medway"),
                  new LocalModel(134, 31, "Brighton and Hove"),
                  new LocalModel(135, 31, "Crawley"),
                  new LocalModel(136, 31, "East Sussex"),
                  new LocalModel(137, 31, "High Weald Lewes Havens"),
                  new LocalModel(138, 31, "Horsham"),
                  new LocalModel(139, 31, "Mid Sussex"),
                  new LocalModel(140, 32, "East Berkshire"),
                  new LocalModel(141, 32, "North East Hampshire and Farnham"),
                  new LocalModel(142, 32, "Surrey Heath"),
                  new LocalModel(143, 33, "Elmbridge"),
                  new LocalModel(144, 33, "Epsom and Ewell"),
                  new LocalModel(145, 33, "Guildford"),
                  new LocalModel(146, 33, "Mole Valley"),
                  new LocalModel(147, 33, "Reigate and Banstead"),
                  new LocalModel(148, 33, "Runnymede"),
                  new LocalModel(149, 33, "Spelthorne"),
                  new LocalModel(150, 33, "Tandridge"),
                  new LocalModel(151, 33, "Waverley and Woking"),
                  new LocalModel(152, 34, "Oxford City"),
                  new LocalModel(153, 34, "North"),
                  new LocalModel(154, 34, "North East"),
                  new LocalModel(155, 34, "South East"),
                  new LocalModel(156, 34, "South West"),
                  new LocalModel(157, 34, "West"),
                  new LocalModel(158, 35, "Southampton"),
                  new LocalModel(159, 35, "South East Hampshire"),
                  new LocalModel(160, 35, "South West Hampshire"),
                  new LocalModel(161, 35, "Isle of Wight"),
                  new LocalModel(162, 35, "North and Mind Hampshire"),
                  new LocalModel(163, 36, "Cornwall"),
                  new LocalModel(164, 36, "the Isles of Scilly"),
                  new LocalModel(165, 37, "Northern, Eastern and Western Devon"),
                  new LocalModel(166, 37, "South Devon and Torbay"),
                  new LocalModel(167, 38, "Taunton"),
                  new LocalModel(168, 38, "Somerset"),
                  new LocalModel(169, 39, "Bristol"),
                  new LocalModel(170, 39, "Inner City and East (ICE) Bristol"),
                  new LocalModel(171, 39, "North and West Bristol "),
                  new LocalModel(172, 39, "South Bristol"),
                  new LocalModel(173, 39, "North Somerset"),
                  new LocalModel(174, 39, "Woodspring"),
                  new LocalModel(175, 39, "South Gloucestershire"),
                  new LocalModel(176, 40, "Bath and North East Somerset"),
                  new LocalModel(177, 40, "Swindon"),
                  new LocalModel(178, 40, "Wiltshire"),
                  new LocalModel(179, 41, "Dorset"),
                  new LocalModel(180, 41, "Poole"),
                  new LocalModel(181, 41, "Salisbury"),
                  new LocalModel(182, 41, "Yeovil"),
                  new LocalModel(183, 42, "Cheltenham"),
                  new LocalModel(184, 42, "Cotswolds"),
                  new LocalModel(185, 42, "Forest of Dean"),
                  new LocalModel(186, 42, "Gloucester City"),
                  new LocalModel(187, 42, "Stroud and Berkeley Vale"),
                  new LocalModel(188, 42, "Tewkesbury, Newent and Staunton")
                );
                // Save Local Data
                context.SaveChanges();
                #endregion
#region RegionalModel Generation
                // Create Regional Model Data
                // Check for any records already in database.
                if (context.RegionalModels.Any())
                {
                    return;   // Database has been seeded
                }
                context.RegionalModels.AddRange(
                  new RegionalModel(1, 1, "Cumbria and the North East"),
                  new RegionalModel(2, 1, "West Yorkshire and Harrogate"),
                  new RegionalModel(3, 1, "Humber, Coast and Vale"),
                  new RegionalModel(4, 1, "South Yorkshire and Bassetlaw"),

                  new RegionalModel(5, 2, "Lancashire and South Cumbria"),
                  new RegionalModel(6, 2, "Greater Manchester"),
                  new RegionalModel(7, 2, "Cheshire and Merseyside"),

                  new RegionalModel(8, 5, "Staffordshire and Stoke on Trent"),
                  new RegionalModel(9, 5, "Shropshire and Telford and Wrekin"),
                  new RegionalModel(10, 5, "Derbyshire"),
                  new RegionalModel(11, 5, "Lincolnshire"),
                  new RegionalModel(12, 5, "Nottinghamshire"),
                  new RegionalModel(13, 5, "Leicester, Leicestershire and Rutland"),
                  new RegionalModel(14, 5, "The Black Country"),
                  new RegionalModel(15, 5, "Birmingham and Solihull"),
                  new RegionalModel(16, 5, "Coventry and Warwickshire"),
                  new RegionalModel(17, 5, "Herefordshire and Worcestershire"),
                  new RegionalModel(18, 5, "Northamptonshire"),

                  new RegionalModel(19, 3, "Cambridgeshire and Peterborough"),
                  new RegionalModel(20, 3, "Norfolk and Waveney"),
                  new RegionalModel(21, 3, "Suffolk and North East Essex"),
                  new RegionalModel(22, 3, "Bedfordshire, Luton and Milton Keynes"),
                  new RegionalModel(23, 3, "Hertfordshire and West Essex"),
                  new RegionalModel(24, 3, "Mid and South Essex"),

                  new RegionalModel(25, 4, "North West London"),
                  new RegionalModel(26, 4, "Central London"),
                  new RegionalModel(27, 4, "East London"),
                  new RegionalModel(28, 4, "South East London"),
                  new RegionalModel(29, 4, "South West London"),

                  new RegionalModel(30, 6, "Kent and Medway"),
                  new RegionalModel(31, 6, "Sussex and East Surrey"),
                  new RegionalModel(32, 6, "Frimley Health and Care"),
                  new RegionalModel(33, 6, "Surrey Heartlands"),
                  new RegionalModel(34, 6, "Buckinghamshire, Oxfordshire and Berkshire West"),
                  new RegionalModel(35, 6, "Hampshire and Isle of Wight"),

                  new RegionalModel(36, 7, "Cornwall and the Isles of Scilly"),
                  new RegionalModel(37, 7, "Devon"),
                  new RegionalModel(38, 7, "Somerset"),
                  new RegionalModel(39, 7, "Bristol, North Somerset and South Gloucestershire"),
                  new RegionalModel(40, 7, "Bath and North East Somerset, Swindon and Wiltshire"),
                  new RegionalModel(41, 7, "Dorset"),
                  new RegionalModel(42, 7, "Gloucestershire")
                );
                // Save Regional Data
                context.SaveChanges();
                #endregion
#region NationalModel Generation
                // Create National Model Data
                // Check for any records already in database.
                if (context.NationalModels.Any())
                {
                    return;   // Database has been seeded
                }
                context.NationalModels.AddRange(
                  new NationalModel(1, "North east and Yorkshire"),
                  new NationalModel(2, "North west"),
                  new NationalModel(3, "East of England"),
                  new NationalModel(4, "London"),
                  new NationalModel(5, "Midlands"),
                  new NationalModel(6, "South East"),
                  new NationalModel(7, "South West")
                );
                // Save National Data
                context.SaveChanges();
#endregion
                // populate National Model with Regional Data
                foreach ( NationalModel model in context.NationalModels)
                {
                    model.Regions = context.RegionalModels.Where(x => x.NationalId == model.Id).ToList();
                }
                // Populate Regional Model with Local Data (TODO)
            }
        }
    }
}

