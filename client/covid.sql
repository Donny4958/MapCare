-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-09-2023 a las 23:57:38
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
-- Estructura de tabla para la tabla `covid`
--

CREATE TABLE `covid` (
  `estado` varchar(50) NOT NULL,
  `cantidad` bigint(20) NOT NULL,
  `clave` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `covid`
--

INSERT INTO `covid` (`estado`, `cantidad`, `clave`) VALUES
('Alabama', 1305761, 'Birmingham, AL'),
('Alaska', 0, 'Juneau, AK'),
('Arizona', 1769981, 'Phoenix, AZ'),
('Arkansas', 0, 'Little Rock, AR'),
('California', 11300486, 'Sacramento, CA'),
('Colorado', 7627999, 'Denver, CO'),
('Connecticut', 0, 'Hartford, CT'),
('Delaware', 0, 'Dover, DE'),
('Florida', 2343807, 'Tallahassee, FL'),
('Georgia', 2033879, 'Atlanta, GA'),
('Hawaii', 0, 'Honolulu, HI'),
('Idaho', 0, 'Boise, ID'),
('Illinois', 3706263, 'Chicago, IL'),
('Indiana', 1713220, 'Indianapolis, IN'),
('Iowa', 0, 'Des Moines, IA'),
('Kansas', 0, 'Topeka, KS'),
('Kentucky', 1459308, 'Louisville, KY'),
('Louisiana', 2048722, 'New Orleans, LA'),
('Maine', 0, 'Augusta, ME'),
('Maryland', 2486671, 'Baltimore, MD'),
('Massachusetts', 3119532, 'Boston, MA'),
('Michigan', 1552840, 'Detroit, MI'),
('Minnesota', 1592300, 'Minneapolis, MN'),
('Mississippi', 0, 'Jackson, MS'),
('Missouri', 2995906, 'Kansas City, MO'),
('Montana', 0, 'Helena, MT'),
('Nebraska', 0, 'Lincoln, NE'),
('Nevada', 0, 'Carson City, NV'),
('New Hampshire', 0, 'Concord, NH'),
('New Jersey', 3501415, 'Newark, NJ'),
('New Mexico', 0, 'Santa Fe, NM'),
('New York', 0, 'Albany, NY'),
('North Carolina', 2364399, 'Raleigh, NC'),
('North Dakota', 0, 'Bismarck, ND'),
('Ohio', 0, 'Columbus, OH'),
('Oklahoma', 1270844, 'Oklahoma City, OK'),
('Oregon', 0, 'Salem, OR'),
('Pennsylvania', 0, 'Harrisburg, PA'),
('Rhode Island', 0, 'Providence, RI'),
('South Carolina', 0, 'Columbia, SC'),
('South Dakota', 0, 'Pierre, SD'),
('Tennessee', 8508204, 'Nashville, TN'),
('Texas', 2323255, 'Austin, TX'),
('Utah', 0, 'Salt Lake City, UT'),
('Vermont', 0, 'Montpelier, VT'),
('Virginia', 1969833, 'Richmond, VA'),
('Washington', 0, 'Olympia, WA'),
('West Virginia', 0, 'Charleston, WV'),
('Wisconsin', 0, 'Milwaukee, WI'),
('Wyoming', 0, 'Cheyenne, WY');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
