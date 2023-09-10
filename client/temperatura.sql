-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-09-2023 a las 23:57:54
-- Versión del servidor: 10.4.28-MariaDB
-- Versión de PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `enfermedades`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `temperatura`
--

CREATE TABLE `temperatura` (
  `estado` varchar(50) NOT NULL,
  `clave` varchar(100) NOT NULL,
  `temp` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `temperatura`
--

INSERT INTO `temperatura` (`estado`, `clave`, `temp`) VALUES
('Alabama', 'Montgomery, AL', 73),
('Alaska', 'Juneau, AK', 65),
('Arizona', 'Phoenix, AZ', 66),
('Arkansas', 'Little Rock, AR', 76),
('California', 'Sacramento, CA', 89),
('Colorado', 'Denver, CO', 89),
('Connecticut', 'Hartford, CT', 74),
('Delaware', 'Dover, DE', 77),
('Florida', 'Tallahassee, FL', 85),
('Georgia', 'Atlanta, GA', 80),
('Hawaii', 'Honolulu, HI', 83),
('Idaho', 'Boise, ID', 67),
('Illinois', 'Springfield, IL', 75),
('Indiana', 'Indianapolis, IN', 81),
('Iowa', 'Des Moines, IA', 71),
('Kansas', 'Topeka, KS', 68),
('Kentucky', 'Frankfort, KY', 74),
('Louisiana', 'Baton Rouge, LA', 80),
('Maine', 'Augusta, ME', 69),
('Maryland', 'Annapolis, MD', 76),
('Massachusetts', 'Boston, MA', 72),
('Michigan', 'Lansing, MI', 74),
('Minnesota', 'St. Paul, MN', 72),
('Mississippi', 'Jackson, MS', 81),
('Missouri', 'Jefferson City, MO', 70),
('Montana', 'Helena, MT', 66),
('Nebraska', 'Lincoln, NE', 78),
('Nevada', 'Carson City, NV', 87),
('New Hampshire', 'Concord, NH', 71),
('New Jersey', 'Trenton, NJ', 78),
('New Mexico', 'Santa Fe, NM', 85),
('New York', 'Albany, NY', 79),
('North Carolina', 'Raleigh, NC', 85),
('North Dakota', 'Bismarck, ND', 65),
('Ohio', 'Columbus, OH', 76),
('Oklahoma', 'Oklahoma City, OK', 79),
('Oregon', 'Salem, OR', 68),
('Pennsylvania', 'Harrisburg, PA', 74),
('Rhode Island', 'Providence, RI', 75),
('South Carolina', 'Columbia, SC', 79),
('South Dakota', 'Pierre, SD', 66),
('Tennessee', 'Nashville, TN', 98),
('Texas', 'Austin, TX', 75),
('Utah', 'Salt Lake City, UT', 69),
('Vermont', 'Montpelier, VT', 70),
('Virginia', 'Richmond, VA', 73),
('Washington', 'Olympia, WA', 67),
('West Virginia', 'Charleston, WV', 73),
('Wisconsin', 'Madison, WI', 71),
('Wyoming', 'Cheyenne, WY', 64);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
