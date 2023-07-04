use inventory_management_system;

insert into users(name,phone,date_of_birth,address,shop_name,password,role)
values('Rohan Shrestha','9800000000',date('2017-06-15'),'Siddhipur','Kirana Pasal','rohan123','ADMIN');

insert into users(name,phone,date_of_birth,address,shop_name,password)
values 
    ('Jack Ma','9810000001',date('2017-06-15'),'Dhangadi','Stylish Shop','jack345'),
    ('Bill Gate','9820000002',date('2017-06-15'),'Chitwan','Miniso','bill@'),
    ('Elon Musk','9830000003',date('2017-06-15'),'Pokhara','Good Shop','elonmusk'),
    ('Arnold','9840000004',date('2017-06-15'),'Kathmandu','KK Bakery','arnold'),
    ('Benedith','9850000005',date('2017-06-15'),'Bhaktapur','Bhatbhateni','benedith'),
    ('Tom Cruise','9860000006',date('2017-06-15'),'Lalitpur','BB Mart','tomcruise');