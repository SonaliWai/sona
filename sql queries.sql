select * from employees where job_id in
(
   select job_id from jobs where max_salary > 15000
)




select * from employees where job_id in
(
   select job_id from jobs where max_salary > 15000 AND min_salary < 20000
)

--Salim assign
--eg.1
SELECT  MAX(salary) 
  FROM employees
 WHERE salary < (SELECT MAX(salary) 
                 FROM employees                
                );


--eg.3
select * from employees where salary < 10000 OR salary > 20000


select * from employees 
where salary > 10000 AND salary < 20000


SELECT first_name, last_name, salary, department_id
FROM employees
WHERE salary NOT BETWEEN 10000 AND 15000

--eg.2
select  * from employees where salary = (select Max(salary) from employees);

--eg.4
select first_name ,  job_title , manager_id from employees e
inner join jobs j
on
e.job_id = j.job_id


--eg.4 selfjoin
select emp.first_name , empself.first_name as empmanger
from
employees emp
inner join
employees empself
on
 empself.employee_id = emp.manager_id 
 select * from employees

 --eg.4
 select emp.first_name , se.first_name from 
 employees emp
 inner join
 employees se
 on 
 emp.employee_id = se.manager_id

   