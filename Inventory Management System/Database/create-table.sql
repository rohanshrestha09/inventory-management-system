use inventory_management_system;

create table users(
    user_id int not null primary key auto_increment,
    name varchar(50) not null,
    phone varchar(10) not null unique,
    date_of_birth date not null,
    address varchar(100) not null,
    shop_name varchar(50) not null,
    password varchar(50) not null,
    role enum('ADMIN','CUSTOMER') not null default 'CUSTOMER',
    constraint check_phone check(length(phone) = 10),
    created_at timestamp default current_timestamp,
    updated_at datetime default current_timestamp on update current_timestamp
);

create table products(
    product_id int not null primary key auto_increment,
    name varchar(50) not null,
    sku_name varchar(50) not null unique,
    description text not null,
    price float not null,
    quantity int not null,
    brand varchar(50) not null,
    category varchar(50) not null,
    created_at timestamp default current_timestamp,
    updated_at datetime default current_timestamp on update current_timestamp
);

create table orders(
    order_id int not null primary key auto_increment,
    total_units int not null,
    total_amount float not null,
    total_paid_amount float not null,
    delivery_status enum('COMPLETED','IN_PROCESS','CANCELLED') not null default 'IN_PROCESS',
    payment_method enum('CASH','ESEWA','KHALTI','BANK') not null default 'CASH',
    user_id int not null,
    product_id int not null,
    constraint check_total_paid_amount check(total_paid_amount <= total_amount),
    foreign key(user_id) references users(user_id),
    foreign key(product_id) references products(product_id),
    created_at timestamp default current_timestamp,
    updated_at datetime default current_timestamp on update current_timestamp
);

create table orders_products(
    order_product_id int not null primary key auto_increment,
    order_id int not null,
    product_id int not null,
    total_units int not null,
    total_amount int not null,
    foreign key(order_id) references orders(order_id),
    foreign key(product_id) references products(product_id),
    constraint unique_order_product unique (order_id, product_id)
    created_at timestamp default current_timestamp,
    updated_at datetime default current_timestamp on update current_timestamp
)