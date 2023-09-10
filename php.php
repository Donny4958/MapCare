<?php
$host = 'localhost';
$db   = 'enfermedades';
$user = 'root';
$pass = '';
$charset = 'utf8mb4';

$dsn = "mysql:host=$host;dbname=$db;charset=$charset";
$options = [
    PDO::ATTR_ERRMODE            => PDO::ERRMODE_EXCEPTION,
    PDO::ATTR_DEFAULT_FETCH_MODE => PDO::FETCH_ASSOC,
    PDO::ATTR_EMULATE_PREPARES   => false,
];
$pdo = new PDO($dsn, $user, $pass, $options);

$stmt = $pdo->query("SELECT estado, cantidad FROM covid");
$data = $stmt->fetchAll(PDO::FETCH_KEY_PAIR);

header('Content-Type: application/json');
echo json_encode($data);
?>
