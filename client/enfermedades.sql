-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-09-2023 a las 02:55:47
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
  `calidad` enum('Excelente','Bueno','Regular','Malo','Horrible') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `aire`
--

INSERT INTO `aire` (`id`, `estado`, `calidad`) VALUES
(1, 'Alabama', 'Bueno'),
(2, 'Alaska', 'Excelente'),
(3, 'Arizona', 'Regular'),
(4, 'Arkansas', 'Malo'),
(5, 'California', 'Horrible'),
(6, 'Colorado', 'Bueno'),
(7, 'Connecticut', 'Excelente'),
(8, 'Delaware', 'Malo'),
(9, 'Florida', 'Regular'),
(10, 'Georgia', 'Bueno'),
(11, 'Hawaii', 'Excelente'),
(12, 'Idaho', 'Malo'),
(13, 'Illinois', 'Bueno'),
(14, 'Indiana', 'Regular'),
(15, 'Iowa', 'Horrible'),
(16, 'Kansas', 'Bueno'),
(17, 'Kentucky', 'Excelente'),
(18, 'Louisiana', 'Regular'),
(19, 'Maine', 'Malo'),
(20, 'Maryland', 'Horrible'),
(21, 'Massachusetts', 'Bueno'),
(22, 'Michigan', 'Excelente'),
(23, 'Minnesota', 'Malo'),
(24, 'Mississippi', 'Bueno'),
(25, 'Missouri', 'Horrible'),
(26, 'Montana', 'Regular'),
(27, 'Nebraska', 'Bueno'),
(28, 'Nevada', 'Malo'),
(29, 'New Hampshire', 'Horrible'),
(30, 'New Jersey', 'Bueno'),
(31, 'New Mexico', 'Regular'),
(32, 'New York', 'Malo'),
(33, 'North Carolina', 'Bueno'),
(34, 'North Dakota', 'Horrible'),
(35, 'Ohio', 'Regular'),
(36, 'Oklahoma', 'Malo'),
(37, 'Oregon', 'Bueno'),
(38, 'Pennsylvania', 'Horrible'),
(39, 'Rhode Island', 'Regular'),
(40, 'South Carolina', 'Bueno'),
(41, 'South Dakota', 'Malo'),
(42, 'Tennessee', 'Horrible'),
(43, 'Texas', 'Bueno'),
(44, 'Utah', 'Excelente'),
(45, 'Vermont', 'Regular'),
(46, 'Virginia', 'Malo'),
(47, 'Washington', 'Bueno'),
(48, 'West Virginia', 'Horrible'),
(49, 'Wisconsin', 'Regular'),
(50, 'Wyoming', 'Bueno');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `covid`
--

CREATE TABLE `covid` (
  `estado` varchar(50) NOT NULL,
  `cantidad` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `covid`
--

INSERT INTO `covid` (`estado`, `cantidad`) VALUES
('Alabama', 847238),
('Alaska', 1234567),
('Arizona', 537892),
('Arkansas', 478923),
('California', 987654),
('Colorado', 678912),
('Connecticut', 245678),
('Delaware', 128900),
('Florida', 1000234),
('Georgia', 567891),
('Hawaii', 1123456),
('Idaho', 789012),
('Illinois', 345678),
('Indiana', 901234),
('Iowa', 567890),
('Kansas', 234567),
('Kentucky', 890123),
('Louisiana', 456789),
('Maine', 123456),
('Maryland', 789012),
('Massachusetts', 234561),
('Michigan', 890122),
('Minnesota', 456788),
('Mississippi', 123455),
('Missouri', 789011),
('Montana', 234560),
('Nebraska', 890121),
('Nevada', 456787),
('New Hampshire', 123454),
('New Jersey', 789010),
('New Mexico', 234559),
('New York', 890120),
('North Carolina', 456786),
('North Dakota', 123453),
('Ohio', 789009),
('Oklahoma', 234558),
('Oregon', 890119),
('Pennsylvania', 456785),
('Rhode Island', 123452),
('South Carolina', 789008),
('South Dakota', 234557),
('Tennessee', 890118),
('Texas', 456784),
('Utah', 123451),
('Vermont', 789007),
('Virginia', 234556),
('Washington', 890117),
('West Virginia', 456783),
('Wisconsin', 123450),
('Wyoming', 789006);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `temperatura`
--

CREATE TABLE `temperatura` (
  `Nombre` varchar(50) NOT NULL,
  `Temp` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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
