<?php
require_once 'database.php';
require_once 'Penjualan.php';
$db = new MySQLDatabase();
$penjualan = new Penjualan($db);
$id=0;
$kode=0;
// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];
// Handle the different HTTP methods
switch ($method) {
    case 'GET':
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['kode'])){
            $kode = $_GET['kode'];
        }
        if($id>0){    
            $result = $penjualan->get_by_id($id);
        }elseif($kode>0){
            $result = $penjualan->get_by_kode($kode);
        } else {
            $result = $penjualan->get_all();
        }        
       
        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }
        
        header('Content-Type: application/json');
        echo json_encode($val);
        break;
    
    case 'POST':
        // Add a new penjualan
        $penjualan->kode = $_POST['kode'];
        $penjualan->nama = $_POST['nama'];
        $penjualan->harga = $_POST['harga'];
        $penjualan->payment = $_POST['payment'];
       
        $penjualan->insert();
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data penjualan created successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data penjualan not created.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    case 'PUT':
        // Update an existing data
        $_PUT = [];
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['kode'])){
            $kode = $_GET['kode'];
        }
        parse_str(file_get_contents("php://input"), $_PUT);
        $penjualan->kode = $_PUT['kode'];
        $penjualan->nama = $_PUT['nama'];
        $penjualan->harga = $_PUT['harga'];
        $penjualan->payment = $_PUT['payment'];
        if($id>0){    
            $penjualan->update($id);
        }elseif($kode<>""){
            $penjualan->update_by_kode($kode);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data penjualan updated successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data penjualan update failed.';
        }        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    case 'DELETE':
        // Delete a user
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['kode'])){
            $kode = $_GET['kode'];
        }
        if($id>0){    
            $penjualan->delete($id);
        }elseif($kode>0){
            $penjualan->delete_by_kode($kode);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data penjualan deleted successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data penjualan delete failed.';
        }        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    default:
        header("HTTP/1.0 405 Method Not Allowed");
        break;
    }
$db->close()
?>