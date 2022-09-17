SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";

CREATE TABLE `devices` (
  `id` text NOT NULL,
  `password` text NOT NULL,
  `status` text NOT NULL,
  `device_data` text NOT NULL,
  `task` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;
COMMIT;