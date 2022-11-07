CREATE TABLE IF NOT EXISTS `products` (
  `id` int(11) NOT NULL,
  `Name` varchar(100) COLLATE utf8mb4_danish_ci NOT NULL,
  `Type` varchar(100) COLLATE utf8mb4_danish_ci NOT NULL,
  `Description` varchar(2500) COLLATE utf8mb4_danish_ci DEFAULT NULL,
  `ItemNumber` varchar(100) COLLATE utf8mb4_danish_ci NOT NULL,
  `Cost` double NOT NULL,
  `typeId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_danish_ci;



CREATE TABLE IF NOT EXISTS `producttype` (
  `id` int(11) NOT NULL,
  `title` varchar(300) COLLATE utf8mb4_danish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_danish_ci;


INSERT INTO `producttype` (`id`, `title`) VALUES
(1, 'Bil produkter'),
(2, 'Motorcykel produkter'),
(3, 'Cykel produkter');


CREATE TABLE IF NOT EXISTS `sales` (
  `id` int(11) NOT NULL,
  `sale` varchar(200) COLLATE utf8mb4_danish_ci NOT NULL,
  `time` datetime NOT NULL,
  `idProduct` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_danish_ci;


CREATE TABLE  IF NOT EXISTS `stock` (
  `id` int(11) NOT NULL,
  `name` varchar(200) COLLATE utf8mb4_danish_ci NOT NULL,
  `amount` int(11) DEFAULT NULL,
  `idProducts` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_danish_ci;


ALTER TABLE `products`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `producttype`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `sales`
  ADD PRIMARY KEY (`id`);


ALTER TABLE `stock`
  ADD PRIMARY KEY (`id`);


ALTER TABLE `products`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=175;

ALTER TABLE `producttype`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;


ALTER TABLE `sales`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=97;

ALTER TABLE `stock`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=99;

ALTER TABLE `products`
  ADD CONSTRAINT `products_ibfk_1` FOREIGN KEY (`typeId`) REFERENCES `producttype` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;


ALTER TABLE `stock`
  ADD CONSTRAINT `stock_ibfk_1` FOREIGN KEY (`idProducts`) REFERENCES `products` (`id`);
COMMIT;
