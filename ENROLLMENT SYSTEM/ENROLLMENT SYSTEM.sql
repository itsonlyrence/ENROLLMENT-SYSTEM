
USE schoolsystem;
go
CREATE TABLE users (
	username VARCHAR(50) NOT NULL,
    password VARCHAR(50) NOT NULL,
    acess_level INT NOT NULL
);
INSERT INTO users(username, password, acess_level) VALUES
('admin', 'admin', '1'),
('registrar', 'registrar','2'),
('cashier', 'cashier', '3');

CREATE TABLE teachersDATA (
    id INT NOT NULL,
    teacher_id VARCHAR(500) NOT NULL,
    teacher_name VARCHAR(100) NOT NULL,
    teacher_gender VARCHAR(100) NOT NULL,
    teacher_address VARCHAR(200) NOT NULL,
    teacher_image VARCHAR(200) NOT NULL,
    teacher_status VARCHAR(200) NOT NULL,
	teacher_grade VARCHAR(200) NOT NULL,
    date_insert DATETIME DEFAULT GETDATE(),
    date_update DATETIME,
    date_delete DATETIME,
);

CREATE TABLE studentsDATA (
     id INT NOT NULL,
    student_id INT NOT NULL,
    student_name VARCHAR(100) NOT NULL,
    student_gender VARCHAR(10) NOT NULL,
    student_address VARCHAR(200) NOT NULL,
    student_grade VARCHAR(10) NOT NULL,
    student_section VARCHAR(10) NOT NULL,
    student_image VARCHAR(200) NOT NULL,
    student_status VARCHAR(20) NOT NULL,
	aycode varchar(50),
    date_insert DATETIME DEFAULT GETDATE(),
    date_update DATETIME,
    date_delete DATETIME,
);

CREATE TABLE tblay (
  aycode varchar(50) NOT NULL PRIMARY KEY,
  status varchar(50) NOT NULL DEFAULT 'Open'
); 

INSERT INTO tblay (aycode, status) VALUES
('2021-2022', 'Close'),
('2022-2023', 'Close'),
('2023-2024', 'Open');

CREATE TABLE tblfees (
  id int NOT NULL PRIMARY KEY,
  fees varchar(50) NOT NULL,
  amount decimal(10,2) NOT NULL
) ;

INSERT INTO tblfees (id, fees, amount) VALUES
(1, 'Tuition', '25000.00'),
(2, 'Registration', '1500.00'),
(3, 'Library', '250.00'),
(4, 'Computer Laboratory', '1500.00');

