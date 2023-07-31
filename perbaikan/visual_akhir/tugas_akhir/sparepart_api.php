<?php
require_once 'database.php';
require_once 'Sparepart.php';
$db = new MySQLDatabase();
$sparepart = new Sparepart($db);
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
            $result = $sparepart->get_by_id($id);
        }elseif($kode>0){
            $result = $sparepart->get_by_kode($kode);
        } else {
            $result = $sparepart->get_all();
        }        
       
        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }
        
        header('Content-Type: application/json');
        echo json_encode($val);
        break;
    
    case 'POST':
        // Add a new sparepart
        $sparepart->kode = $_POST['kode'];
        $sparepart->nama = $_POST['nama'];
        $sparepart->harga = $_POST['harga'];
        $sparepart->stok = $_POST['stok'];
       
        $sparepart->insert();
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data sparepart created successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data sparepart not created.';
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
        $sparepart->kode = $_PUT['kode'];
        $sparepart->nama = $_PUT['nama'];
        $sparepart->harga = $_PUT['harga'];
        $sparepart->stok = $_PUT['stok'];
        if($id>0){    
            $sparepart->update($id);
        }elseif($kode<>""){
            $sparepart->update_by_kode($kode);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data sparepart updated successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data sparepart update failed.';
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
            $sparepart->delete($id);
        }elseif($kode>0){
            $sparepart->delete_by_kode($kode);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data sparepart deleted successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data sparepart delete failed.';
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