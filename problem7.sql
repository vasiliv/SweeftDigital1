CREATE DATABASE Sweeftdigital;

CREATE TABLE Teacher (
    teacher_id INT PRIMARY KEY IDENTITY (1, 1),
    first_name VARCHAR (50) NOT NULL,
    last_name VARCHAR (50) NOT NULL,
    Sex Bit,
    Lecture VARCHAR(20)
);

CREATE TABLE Pupil (
    pupil_id INT PRIMARY KEY IDENTITY (1, 1),
    first_name VARCHAR (50) NOT NULL,
    last_name VARCHAR (50) NOT NULL,
    Sex Bit,
    class VARCHAR(20)
);


CREATE TABLE TeacherPupil (
    pupil_id INT not null
		foreign key references Pupil(pupil_id),
	teacher_id INT not null
		foreign key references Teacher(teacher_id),
	primary key(pupil_id, teacher_id)
);


SELECT first_name, last_name
FROM Teacher
INNER JOIN TeacherPupil ON Teacher.teacher_id = TeacherPupil.teacher_id
INNER JOIN Pupil ON Pupil.pupil_id = TeacherPupil.pupil_id
WHERE Pupil.first_name = 'Giorgi'