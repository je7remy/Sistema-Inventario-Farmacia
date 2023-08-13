-- Insertando datos en la tabla "Producto" relacionados con la categoría "Cuidado Personal"
INSERT INTO [dbo].[Producto] ([Nombre], [Id_Categoria], [Marca], [Fecha_De_Vencimiento], [Existencia], [Precio_De_Venta])
VALUES ('Jabón de Manos', 1, 'Dove', '2024-06-30', 100, 2.99),
       ('Champú Anticaspa', 1, 'Head & Shoulders', '2023-12-15', 50, 5.49);

-- Insertando datos en la tabla "Producto" relacionados con la categoría "Vitaminas"
INSERT INTO [dbo].[Producto] ([Nombre], [Id_Categoria], [Marca], [Fecha_De_Vencimiento], [Existencia], [Precio_De_Venta])
VALUES ('Vitamina C', 2, 'Nature''s Bounty', '2025-03-10', 200, 9.99),
       ('Complejo B', 2, 'Centrum', '2024-09-30', 150, 12.95);

-- Insertando datos en la tabla "Producto" relacionados con la categoría "Dermocosmética"
INSERT INTO [dbo].[Producto] ([Nombre], [Id_Categoria], [Marca], [Fecha_De_Vencimiento], [Existencia], [Precio_De_Venta])
VALUES ('Crema Hidratante', 3, 'Neutrogena', '2024-08-20', 80, 15.75),
       ('Protector Solar SPF 50', 3, 'La Roche-Posay', '2023-11-01', 120, 22.99);

-- Insertando datos en la tabla "Producto" relacionados con las categorías restantes
-- Puedes continuar este patrón para las demás categorías

-- Categoria "Bienestar"
INSERT INTO [dbo].[Producto] ([Nombre], [Id_Categoria], [Marca], [Fecha_De_Vencimiento], [Existencia], [Precio_De_Venta])
VALUES ('Aceite Esencial de Lavanda', 4, 'Now Foods', '2024-07-15', 90, 8.50);

-- Categoria "Bebés"
INSERT INTO [dbo].[Producto] ([Nombre], [Id_Categoria], [Marca], [Fecha_De_Vencimiento], [Existencia], [Precio_De_Venta])
VALUES ('Pañales Talla 1', 5, 'Pampers', '2023-10-20', 200, 19.99);

-- Categoria "Nutrición Deportiva"
INSERT INTO [dbo].[Producto] ([Nombre], [Id_Categoria], [Marca], [Fecha_De_Vencimiento], [Existencia], [Precio_De_Venta])
VALUES ('Proteína en Polvo', 6, 'Optimum Nutrition', '2024-04-30', 75, 29.95);

-- Categoria "Herboristería"
INSERT INTO [dbo].[Producto] ([Nombre], [Id_Categoria], [Marca], [Fecha_De_Vencimiento], [Existencia], [Precio_De_Venta])
VALUES ('Té de Hierbas Relajante', 7, 'Yogi Tea', '2023-09-15', 100, 4.75);

-- Categoria "Veterinaria"
INSERT INTO [dbo].[Producto] ([Nombre], [Id_Categoria], [Marca], [Fecha_De_Vencimiento], [Existencia], [Precio_De_Venta])
VALUES ('Shampoo para Mascotas', 8, 'Hartz', '2024-05-31', 50, 6.99);

-- Categoria "Ortopedia"
INSERT INTO [dbo].[Producto] ([Nombre], [Id_Categoria], [Marca], [Fecha_De_Vencimiento], [Existencia], [Precio_De_Venta])
VALUES ('Muñequera Ajustable', 9, 'FUTURO', '2023-12-10', 30, 11.25);

-- Categoria "Antialérgicos"
INSERT INTO [dbo].[Producto] ([Nombre], [Id_Categoria], [Marca], [Fecha_De_Vencimiento], [Existencia], [Precio_De_Venta])
VALUES ('Antihistamínico', 10, 'Claritin', '2024-02-28', 60, 9.50);

-- Categoria "Antiácidos"
INSERT INTO [dbo].[Producto] ([Nombre], [Id_Categoria], [Marca], [Fecha_De_Vencimiento], [Existencia], [Precio_De_Venta])
VALUES ('Tabletas de Alivio Ácido', 11, 'Tums', '2023-11-15', 75, 7.25);

-- Categoria "Laxantes"
INSERT INTO [dbo].[Producto] ([Nombre], [Id_Categoria], [Marca], [Fecha_De_Vencimiento], [Existencia], [Precio_De_Venta])
VALUES ('Supositorios Laxantes', 12, 'Dulcolax', '2024-09-01', 40, 8.99);
