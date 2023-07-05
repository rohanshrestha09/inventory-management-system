use inventory_management_system;

insert into orders(total_amount,total_paid_amount,delivery_status,payment_method,user_id)
values(5000,4500,'IN_PROCESS','CASH',1),
	(10000,9000,'COMPLETED','BANK',1),
    (150000,50000,'CANCELLED','ESEWA',1),
    (2000,2000,'COMPLETED','KHALTI',1),
    (25000,4500,'IN_PROCESS','CASH',1);