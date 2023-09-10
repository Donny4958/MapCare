-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-09-2023 a las 23:57:49
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
-- Estructura de tabla para la tabla `aire`
--

CREATE TABLE `aire` (
  `id` int(11) NOT NULL,
  `estado` varchar(255) NOT NULL,
  `calidad` varchar(255) DEFAULT NULL,
  `clave` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `aire`
--

INSERT INTO `aire` (`id`, `estado`, `calidad`, `clave`) VALUES
(1, 'Alabama', 'Good', 'Birmingham, AL'),
(2, 'Alaska', 'Moderate', 'Juneau, AK'),
(3, 'Arizona', 'Moderate', 'Phoenix, AZ'),
(4, 'Arkansas', 'Good', 'Little Rock, AR'),
(5, 'California', 'Good', 'Sacramento, CA'),
(6, 'Colorado', 'Moderate', 'Denver, CO'),
(7, 'Connecticut', 'Bad', 'Hartford, CT'),
(8, 'Delaware', 'Moderate', 'Dover, DE'),
(9, 'Florida', 'Good', 'Tallahassee, FL'),
(10, 'Georgia', 'Good', 'Atlanta, GA'),
(11, 'Hawaii', 'Moderate', 'Honolulu, HI'),
(12, 'Idaho', 'Good', 'Boise, ID'),
(13, 'Illinois', 'Bad', 'Springfield, IL'),
(14, 'Indiana', 'Good', 'Indianapolis, IN'),
(15, 'Iowa', 'Moderate', 'Des Moines, IA'),
(16, 'Kansas', 'Bad', 'Topeka, KS'),
(17, 'Kentucky', 'Good', 'Louisville, KY'),
(18, 'Louisiana', 'Moderate', 'New Orleans, LA'),
(19, 'Maine', 'Bad', 'Augusta, ME'),
(20, 'Maryland', 'Good', 'Baltimore, MD'),
(21, 'Massachusetts', 'Moderate', 'Boston, MA'),
(22, 'Michigan', 'Bad', 'Detroit, MI'),
(23, 'Minnesota', 'Good', 'Minneapolis, MN'),
(24, 'Mississippi', 'Moderate', 'Jackson, MS'),
(25, 'Missouri', 'Good', 'Kansas City, MO'),
(26, 'Montana', 'Bad', 'Helena, MT'),
(27, 'Nebraska', 'Moderate', 'Lincoln, NE'),
(28, 'Nevada', 'Good', 'Carson City, NV'),
(29, 'New Hampshire', 'Bad', 'Concord, NH'),
(30, 'New Jersey', 'Moderate', 'Newark, NJ'),
(31, 'New Mexico', 'Good', 'Santa Fe, NM'),
(32, 'New York', 'Bad', 'Albany, NY'),
(33, 'North Carolina', 'Good', 'Raleigh, NC'),
(34, 'North Dakota', 'Good', 'Bismarck, ND'),
(35, 'Ohio', 'Bad', 'Columbus, OH'),
(36, 'Oklahoma', 'Good', 'Oklahoma City, OK'),
(37, 'Oregon', 'Good', 'Salem, OR'),
(38, 'Pennsylvania', 'Bad', 'Harrisburg, PA'),
(39, 'Rhode Island', 'Good', 'Providence, RI'),
(40, 'South Carolina', 'Moderate', 'Columbia, SC'),
(41, 'South Dakota', 'Bad', 'Pierre, SD'),
(42, 'Tennessee', 'Moderate', 'Nashville, TN'),
(43, 'Texas', 'Good', 'Austin, TX'),
(44, 'Utah', 'Bad', 'Salt Lake City, UT'),
(45, 'Vermont', 'Good', 'Montpelier, VT'),
(46, 'Virginia', 'Good', 'Richmond, VA'),
(47, 'Washington', 'Bad', 'Olympia, WA'),
(48, 'West Virginia', 'Good', 'Charleston, WV'),
(49, 'Wisconsin', 'Moderate', 'Milwaukee, WI'),
(50, 'Wyoming', 'Bad', 'Cheyenne, WY');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `aire`
--
ALTER TABLE `aire`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `aire`
--
ALTER TABLE `aire`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
