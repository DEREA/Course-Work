drop database sys;
create database sys;
use sys;
 
 create table Surgery(
 
 surgeryNo varchar(255) not null,
 surgeryName varchar(255) not null,
 primary key(surgeryNo)
 );
 
 
 create table Patient (
 
 patientNo varchar(255) not null,
 patientName varchar(255) not null,
 surgeryNo varchar(255) not null references Surgery(surgeryName),
 primary key (patientNo)
 
 );
 
 create table Doctor(
 
 staffNo varchar(255) not null,
 doctorName varchar(255) not null,
 primary key (staffNo)
 
 );
 
 
 create table Appointment(
 
 staffNo varchar(255) not null references Doctor(staffNo),
 patientNo varchar(255) not null references Patient(patientNo),
 appointmentNo varchar(255) not null,
 appointment date not null,
 primary key (appointmentNo)
 
 );
 