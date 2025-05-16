-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 05-09-2019 a las 17:39:21
-- Versión del servidor: 10.1.31-MariaDB
-- Versión de PHP: 7.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `dbsistemavotacion`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbactas`
--

CREATE TABLE `tbactas` (
  `id_acta` int(6) UNSIGNED ZEROFILL NOT NULL,
  `jrv` int(4) UNSIGNED ZEROFILL NOT NULL,
  `mesa_votacion` int(5) UNSIGNED ZEROFILL NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbcandidatos`
--

CREATE TABLE `tbcandidatos` (
  `id_candidato` int(2) UNSIGNED ZEROFILL NOT NULL,
  `nombre_candidato` varchar(25) NOT NULL,
  `estado_candidato` int(2) UNSIGNED ZEROFILL NOT NULL,
  `tipo_candidato` int(2) UNSIGNED ZEROFILL NOT NULL,
  `partido_candidato` int(2) UNSIGNED ZEROFILL NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbcandidatos`
--

INSERT INTO `tbcandidatos` (`id_candidato`, `nombre_candidato`, `estado_candidato`, `tipo_candidato`, `partido_candidato`) VALUES
(04, 'Mauricio Funes', 01, 04, 01),
(05, 'Adalberto Aguilar', 01, 03, 02);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbcentros_votacion`
--

CREATE TABLE `tbcentros_votacion` (
  `id_centro_votacion` int(9) UNSIGNED ZEROFILL NOT NULL,
  `municipio_centro_votacion` int(2) UNSIGNED ZEROFILL NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbcentros_votacion`
--

INSERT INTO `tbcentros_votacion` (`id_centro_votacion`, `municipio_centro_votacion`) VALUES
(000000005, 04);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbdepartamentos`
--

CREATE TABLE `tbdepartamentos` (
  `id_departamento` int(2) UNSIGNED ZEROFILL NOT NULL,
  `Nombre_dep` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbdepartamentos`
--

INSERT INTO `tbdepartamentos` (`id_departamento`, `Nombre_dep`) VALUES
(02, 'San Salvador');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbdiscapacidades`
--

CREATE TABLE `tbdiscapacidades` (
  `id_discapacidad` int(6) UNSIGNED ZEROFILL NOT NULL,
  `nombre` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbdiscapacidades`
--

INSERT INTO `tbdiscapacidades` (`id_discapacidad`, `nombre`) VALUES
(000001, 'En silla de ruedas'),
(000002, 'Disfunción mental'),
(000003, 'Ceguera'),
(000004, 'Discapacidad Auditiva'),
(000005, 'Incapacidad de Hablar'),
(000006, 'Malfunción Auditiva'),
(000007, 'Ninguna'),
(000008, 'Discapacidad Visual');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbempresas`
--

CREATE TABLE `tbempresas` (
  `id_empresa` int(11) NOT NULL,
  `empresa` varchar(45) DEFAULT NULL,
  `nit` varchar(17) DEFAULT NULL,
  `representante_legal` varchar(75) DEFAULT NULL,
  `tipo_empresa` int(11) NOT NULL,
  `estado_empresa` int(1) NOT NULL,
  `direccion` varchar(150) DEFAULT NULL,
  `logoempresa` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbempresas`
--

INSERT INTO `tbempresas` (`id_empresa`, `empresa`, `nit`, `representante_legal`, `tipo_empresa`, `estado_empresa`, `direccion`, `logoempresa`) VALUES
(1, 'hsljakd', 'ihgiudhfu', 'hhhdskjfhk', 0, 1, 'hdkjsfhkjds', '/9j/4AAQSkZJRgABAQEAAAAAAAD/2wBDAAkGBxMTEhUTExMWFRUXGBgXGBgXGBcXGBgYGBgYGBgXFxgaHSggGBolGxgVIjEiJSkrLi4uFx8zODMtNygtLiv/2wBDAQoKCg4NDhoQEBstJR8lLS8tLS0tLS0tLS0tLS0tLS0vLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS3/wAARCACwAR4DASIAAhEBAxEB/8QAGwAAAgMBAQEAAAAAAAAAAAAABAUCAwYBAAf/xABEEAABAwIDBQUGAgkCBAcAAAABAAIRAyEEEjEFQVFhkQYicYGhEzKxwdHwYuEjQlJygpKisvEUJBYzQ9IHFTRTY3PC/8QAGgEAAgMBAQAAAAAAAAAAAAAAAQIAAwQFBv/EAC0RAAICAQMDAwMCBwAAAAAAAAABAhEDEiExBEFREyIyYXGhFIEFQpGxwdHw/9oADAMBAAIRAxEAPwDGdnMa6liGOaASTlg6d62u5fW6NYmzhldw+YO8L4kCtp2c7WiG0cTdos2oPebwn6qrPjb3QMclVM+ggKYCGp1coBJDmHR40PjwRbVlLGeAUgF0NUw1EUiApgLoapAKEsiGruVTQ+JxjGQTJkx3Wl0eMCw5lQBa1q6bLO7S7UMYXNzAg2aaJzvHMgtytPidyQ4zalaoQ12VkDuPcGvqieBADWm24JlBsZRNdjdssYHXDSDH6XNTaeMEi/ks5ju1bnE+xDnEC7XQKfM6Zj6LLYrFsiXuL6gOriXH10QGL205ziWDLIhWxxWG1EcYvGuIBc/Kw602dxg5QDfzSittBjQ5rBImxQdHDVap7rXO8Afim2E7KVXXeQwdSrKjH5MTU3whPWxj3andFlClRc4w0EnkJWwp7Bw9IS85j+I26Bcq7boUrMaPIKesuIIjg+ZMTYTs9WfEtDB+L6BS9h7MlhM5SRKtxG3az7MGUeqowmHdvuTcpo6v5ijK41SZcCr6RXG4cyiGUCmoz2gIj9M2OB+C0GyMIa1QMFhqTwA1KTUKE1yODJ+C2nY+mA+pxyW63RdqLZNnJJj7D0GsaGsENHrzPEq6h7wXCLL1CzgVis3VsMHIPE6I1yExIsmQiM1tQapdgKN02x9OULhqZB0ViZbWw0Yxdw1YB4bvcVLBTUFhAFpOiHxhpUSX589SIaBo2bSkbAlvQi7Tl1SmwCJaTA4hYl+KhbGo8uPgsl2hoBlYgbwHddVZiy7uJXnwKlLuVsxEqVWogGleD1o1GX01dh/a3ZIo1Q+lehWGekeAOrPEH0hJFvsPh21WPwNQgZ5qYdx/Uq/s+Dr9SsJXouY5zHAtc0lpB3EWISq17WXQmpx1Ifdmu1FTDHKf0lE6sO7m36L6ZsvGU6tMVKDszN7f1m8o+S+JBMNkbUq4d4fSdB3jc4cCFVkwqW65Loz8n22m6dFa1Z/s52jpYsWIp1gLsO/mOI9Qmrq9UGBh3u5h9LL6uB9Fmpp0xwxzgASbAXSzGbcY1gqNLCJvnd7OBxAIknlCze2sTXD3PaBhzo45i95A8e63yBWfxOKph7ahJqVDrJzOnS3r0CZQsNGkxvahzi51EOqNPdLaga2mJ4Wzun5pLiMSRHtKkU3D/l0/0bBxEA31Gp4oelQxNUuDGezYd77cdB5lF0OyQN61VzuQsPVP7YhvwJ6u2GMDmUxImxHI6/BUNo4rERlY6BYHQdStcyjg8NeGA8Td3qhMV2upi1NheegRU7+MbA/q6FuE7GvN6tQN5NueqbU9i4SgJdBPF5n00SPEbcxNUwCGDlr1S6rhnOfDnF1pJJTaMkvk6K/Uxp7bmmxPaWiyzBm8BASrEber1PdAYPVUUcEBoEbSwqaOGC+pTPqpcIWHDPfd7yUVR2eBuTOnhSj6GBVqRmlkb5Yso4LkjKeEhNKeGAVvsE1FbkKqeFt4oiph4CYijOm5VY4ZRJDjG5oJN+QRArbEexaWavWPBrfU/ktFgahpva9u7XmN46JV2ZwTy6u803gEtAzNcJAnSRdPW4N7tWkD4qXGtw5FO9kzRU3NqNzMMg7uBUGtgpQGVqd6Tbjm0A9Sm2ExDy0e1YA7flNljyY0t0zbhyykqlFp/YJp1IsfIqNc2UHVRzVbiOHqkL6AqtOSvZGgXV76M7yqKmAYfek+JMdApY4qxe0tWUvdGrt3gPql9GgSVpP9FT/ZCV7X29Qwpyls1InK0biTB4DRK4OTLFkUEU1sKGNzv7rRck8F872rjPa1XP0BMAchYI3bu3quJMO7rNzRp4k7ylIC048WjfuZMuZz2OQoq0qshWFSNZVoe0JIJBbcEbn6iPBLO11ZlY06wEVi0trtAtmZAD/4gm2fK0BtyfU8UHiQKbw4tzUz3Kg/aYSM8Rv+iuyRvfujH0uTS6fDMnK9K3G0uxFOnUBbVc6k67bCYNx3t9t8LrMPg8PrkniTmKyvNHsdNQbMpgMHWLg6k18gyHCRB8V9E2dtrHhgD/Yk8SHT5wYlIsR2opNswF3kllftBXf7oyhI9c+w3tjyzdVcIMQwGvBcZnJmYNSALGdOalhNh0GRlpAEaG5PU3UOyYc7DUy8y45pP8bk8YxUO02i5NNJlDcCzh6lU4jY1J/vB/k94+BTEBdQAIf+DsHMmkSedSof/wBK1nZfCDSiP5n/APcnK7CbXLyK4RfYUt7OYUf9IdXfVWUuz2FBJ9i2Trd31TMBTAU1S8g0RXYW/wDk2HGlFvRWN2XRH/SZ0RhC9Cmp+SaI+AduBpDSmz+UKxuGYP1W9ArgF0KamTSvBWKTf2R0ClkA3BS+/wA15SyUjkLoXl0KBOL0KQXEQEYXoUj9+q4oQjC8ur0KEIwolSKiQiEgV86/8Qaf+7bzpN/vqBfRoWO7ZYbNiaR/+Mjo4n5q3D8inO6g2Yj2BXG0Fojs+9guO2fC1uBgWYQ+xUm4dNnYTkuOpclPTB6oQxve5x/Lz6IylQB13aDh+aBpe7zdc+Ot+QG5EU8SCYHhyVxkoC2psysRArOyN0aXHKBwF7JPszY5q1C2e60S53wHifqne2MdlZGhPw4+JRmwcM6nRFu8/wDSO8x3R0jqVTJK9jbiyT0239gOn2fDd0ogbJA3JywbiUbTpDd9/fyUpIqc5PuHbFpBtGmOA+JJR4VdEQ0RwCnK5svkzsw+K+xJeC4hdm7QbWDnMkZXuYQYmQTwO8AdUowaApZUPhsZTeXBj2uLDldBmDwKvDlAHQFJJcJ2kpVMU7DNDszZGb9XM33h6JntCoWslustFubhPpKLVckW5cvQl209tUqLshzPqEFwp02lzi0b4G6xUcFt2nUcGObUovOjarCwu/dOh8JlSmCxoF6F4BI/+KaOZ3dqBjXZDVyTSzWEZhunfCiTZB6VwLjHggEGQbgjQg6RySXaHaH2dV1JlF9YsYX1MhAyNsdD7xuLcwilZB2V0IPB7SZUoisDDC3MZ1AHvAxvEFKcL2ozBj3UXMpVH5KdSQZMx3mwCJM8dDwRSYDRrgS/am1BRfRYWz7V+SZiNADzuQkXa3H4ihiaT6UkPYaYaZyZyXRIGpuD5IpWRs1pXoWcxuLxGEDataq2rTLoeAzLkJkgsIMkePzsZt3aL6L8OQJZUqezfb9r3SDNoufJSiWNiuQpFIe2WIqU8PnpPLC17SS0AnLeRBsd2qiVkHRUUsweBrBwecW97YByllMAjxA8EzI6+igTizPapwFehO9tQdCz6rTLL9t3BrsM87nvHUN+isxupIqzK4NEabbjwKori/h9/RW06gIEX5qmoN/3ZbjkAzhx1VTqd9Fe825oepO5MBguHEkk+AHBEw1jeSFwYgSd/wAN3ohdtYuBlCjdKyRhqlRRh6JxWIDL5dXfuN166ea2T4aCdwtb4eQSjslgSym57rOqRE6hoEjrM+QT174AFiCJP3uVK8mmfaK4Qvw7ie8L8jxTOhXMEx9hDUrz6eP2Qjab4F43yd0bz6wo9hfl2G9Ey1sbwPgrFxosurnPk7C2RILPdjp/3FiP07rH90a2G+60ISLsu85sSDqKp3AbrTxsGid6K4YDO9lcZ7PF1Xm1Ks97Ad2cOzCeB7wH8XJa7b21BQpgD/m1DkptFyXGwMcASOoSrsxhKVfDVQWkU31nlsnvN92CDxBRWxdg1WVjVxFX22RobSN7C9yI1vE31TypvcVcAIwH+jdgnOdJL3squgmXVACPGIInzWtxgsPEJJ25pOOGD2/9Oo2odNBmG/XUWTvEukN5keqSW6sMeTO4oAbVoneaLgefvx98kw7S4QVMPUBHea0vYd4c0Egg7uHmlO18S5u0KJDHVC2k4hjYkl2YE3Im0dUVisTiK4NJlB9EOBDqlQjujeGtBuTpM2una4YCqrtxx2eyq0y94FOXW712uda5uCbJpsfZopYZmHdDwGlrrQHSSTbzKRdp8IKWEpNBMU6jCXHU2dJMcZOi1czdJJ7bDUI+zNdzH18K8yabiWE76brjx1H8yq2EA7FY6D3pa3w/5g6KLrbUbr3qBnhAJ/7QiMXgq1Gq7EUB7QPj2tI2Jge9TMxmHA8Sjf5BR7DbPdhsDUpuPtS1lQ2nvSDAuhsHsw19mUqQgOLQ5pMw05icwjeASm1LFMxWHd7NxAe1zLiC1xBBkcQlvZnaIpMbha/6KqzuNDrB4mxY42drCNv9yUT7TgtODcZOWs0OIA3wCTMxcfmvdrpbVwdQGza8ETaDBJ13AFQ7euIw7HC2Ssxx8AHbt94su9vSDQpz/wC8yDwkO6ox7AZVtzEsxlWnhKTmuaHCpWcDo1pjK0jU3m2llb29kUKZHvNrMIPA5Xb/ACR+L7NYdzXBtJlN5u17AGua7cQRzhZnaWNfW2WXVBmqU6wbIHvEGA4eTvPzRXagG9cs/wBuP/R1PFkfztT1jpAPEA9Um7YU82DrDkDrGjgUFyHsG0cQ1tOnnc1staLuAuQLCdUQUk2TsDCFlKqKTXOytdmOY3gGQCbXvoniDIcWT/8AEKnNOh/9sdWu+i1azPb8xh2O/ZrMP9Lx9E0OQT4B6FmtHCFGLdVXs6rmY0neAruPiugcbvuDVbeKqGqvrttHmg6rkUB7gbnZW66JZs7D/wCorgO90d537o0HiTA8yu7Tr92OKbdmqDadL2jved3v4f1fr5pZu3RdiWmDl3HjWnMOEGfOwHSVFmHubmfiP8qFOsS2dOM/fgpYfEAgkXP1zfkgKk0FPaADeLE/X4qeS4H4i3lAAj4/FUYVufMT4Dzj78kY4Q5hAtng8iSAOoASfUfhaVyOl0KIUlzjsElm+x0mhWeZl9R5E8MoiFoiJB3f4QOxtltoUvZAlwlxJIic3FMnsKBdhnzhGci4aRvWiagdm4FlCmKbJyguN/xOLvmjWqN2ydhT2zpB2Dqzuyno9qMovzUqR4tpnf8AhRGNwjatN1N05XCCRY9eKobhhTbSptmGBrROsNG/oo+KBHkRio07VgzIodzSLzM7960j0OcEz2orQc4aW+RuZV7yjJhQs27gjWoVKY1It4ggj4R5oDZ/aKm3Dszz7VoyGkLvL2CLDcDYybXT5qj/AKOnn9p7NmfTPlGbrqktcMZoU7BwdQ1H4quMr6gAaz9hg0k8TOnjxtVg8W6hiKzcRUhlR2aiXO7sXlok21b08FooUcRQa8ZXta5p1DgCOhU1AozXZOnn/wBW9pIZUqnI4WtB7zbfi15JZjcf/sK1GuZrUnBvfPed3wWuHGASPADitxSotaA1oDWjQAQB4AKjEYCk9we6m1zho4tBI84TqW4KEW36FV+BpU8r3vd7IOgXmJJdw+sKztxmdSpU20zUz1WgxwHA7jfUrQhSDlFIjQor7eqGW0sJXL7Xe3IwE8XTcDkgjsd1DAVmlw9oS6sS0WDgWkBo4DKFqJUZR1Aoy+w+1VI0abD7Uva1rXEU3OEtAEyBeUwxONZiMPVDGvJLHDKWOa64gQCOPwTaVyUbRKMz2e2u9lGlSqYbEAtGUuFLugAmNLxEblpCV1ccoyJHiVnO3jJwbuT6Z/qj5rRFJO2Q/wBnU5Fh6VGox5QJcMQbId+jaN8Ip5Q2CxAc0ZBaBuiOKueDl4feq3rg48lUmVudKGqiTcwFN7jI53Cpq1I0E+KYFGaoUjXrNZum54NF3H74hab250yhouB4WA9Eo2DQLabqm9/dHHIDePEj+lOMOwzLtb+W/wDJVxVmjI0tg1lLQeE/T0XX0pGkHiOAO5Ul0T4E/RFbPM6axfhyTMpTfIdhWxrFtY46xHiZUw4+0Yz9p2c+DYj1jooBwHlf+Ll97lRsZ5fUzn9b3f3Wn5kn0SPhkjvJfc0gUlwLoXNO0dAUgF4KQCJCIVrVENVjQiK2Tag8We+zx+Tka0JZtSrlqNnn/afqoSPJeXqJcg215VudLJlqiXNKtBQzHK5pVdkaLJXZUAuyiLRKV4lQBXnaIko4XblwuQ9WtFxuV+HxrXauHQKIt0OrokKp4dF2s1wEq32jdyhXxQ0TirnZCiuXkzJHCLTzXaO0XN98SOI1/NENh19ytqYObqvdcGmUoVUkdo4lr/dPlv6KZcllXAQvOc5osSfG/wAU6yeSp4E/ixkXJR2pvg637k9CD8kO/bJaYcJHEWK7tfFNfhaxaZ/RP9GnVWQkm9irJhlFbinZoDWAcvkia0keSFwbIY07y0GeAhGatPOPgLrpLhHnp/J/cXH4KguvJ3qVd/oVQ56ZBlsQoUmi7ScrRbwFvXVGsqyJjmfT78kO0CAItqfp8le3S/n9/eiCVBlJye51tQl3n8bffgUyo1g1pMXFo4umGhDUGQQevhb8kXlAIFoE1HHThbzsgwN9ijbFQjJSzd4wHEdXfEBM9k0wIOjQIaOv5JLs8+2rPfFt3JpgeROvRPXPgJGrVDJ6XfgZtxLdZ+KmMQ3Wee9LAd3l52+/JSfU9SAPK/z9FR+niaf1k/CGYxDefTyUauPY1pcZgDggWP1jy9Y+LUj7TYstY4ROjRzNnf8AZ1U9GI0epnJ1safZ+2KdZpczMQHZLtiSOHLmim49kxcny5c+YSDZuF9nSZTmAA7NE6zrPUotrhGbztvBIA01931QWJByZ5LgcM2g3gd3Df5pPtualRmW2uvIBWmpHgP8+gjqgadaXUgTdzXnqQSUHjjqSDizT0yn4r8hNLDuGpG5XtpldpvBmN5mfW3JRdU05/D6KehAR9blfckDCsbV5ff38EM6pr0nqD8FwVRcmwHpA39PVH9PDwI+sy+fwgp1eL/NVvxtpDQfP7lCPqZhNrmQCOnp80ufVcTeDum9uQHpPIo+hDwGPU5W+f7DR22AGkwLagu05EgFUYDbhq4f2/s4GdzQM0+6Ymco1SraFSKbyY0OgF7ceq7sE5cDQB0OZxHHM8n4FLPDFLwasWeTfF/QtrbdnWmP5vyS1+1HAy1seDp+Sqx9JsywyPUeIQYqLLVM7cdLja2GlLtNfK6Wn70KnitszcHS4WdxLc/loVQx8GDr8UzimIp09zd7K2kHEQbHdwncfNaPD4gb18op1S24MFO9ndpnNc0VPdkS4cOJCGnwJkipcm6xkROnx8hvQOIaY4ct/wCSLoVATbvOImdwG7qrauHBHH4dEjVlSlo2ZksVhxO4eqV4yhYtkwRBgkW8lr8VhrafJI8ZhvFJuma4zU1Qpo1yGhrnCG2EiBEC5j3jZMMO+W5jN9x+9EsrtXqeNLRBuPUBdDB1KrTI43Wfw93rx/0/0dxOp8UM90XCjUxEvgWESTx4R0UHvWxPY5cotOmE0amnhPgNw6XRVIT98PsIam2B9/f+USx3y+P+URApr/h6ASepPwVWIa5zAxxjO4l5/CLgD09VCk+Tl1MacAIBJ81Y4l7hGmgHLKQPDUlLyHhh2zgA2RDQbAcYnvO5ooGYA3/ISfkhyBljdp9T4m5U2VZLjzgeG8/BAUKDwDA3CesN+p813SOMepMj5jyVDR/VE+An8+oUhWDpPEn4x0meiAyCg+NPufzIWXx2J9viqdNvutId4uEH45fJqd4qroNBBJ5AXM9T0SXstTz1a1YDk3dc3jzt/Kl7l0ElHU/2NA51iRN73Me6coE7rgdSrw6CANxb0kwPAQB18UJXd3TEjf6ASPOLcir6puBoIHjAEHwtnRoqcrFHaeqP0LLiagPAENbJnj+qhae0s1WgJvZo/dcXgg+UdAlPbLGF9UMmcgv+865HSOql2NpB1UudJyC2+PDhru4qtwuafg3QyaOnaa5N84yABI0B8pt8AuVn2tu81WH3vYDyzEqpz7Tz+Y++qso55GtUcPdFi5o1GhMfADqpPcAyDvI84IAMDjA6hDESWzMgk8NYbfhALj4rvtJqOtpYHllabefzTUAJrPhtuQ6kT80FJJnde2to19fjxVld1oOl/X7+KHJtbfGm/fp6I0GLFHaE5Wkk2ykAc4F+loTilH+lw4FgKTesX9Vne1j5a1g1JAHmf8LU4unBFMnuta1o8Wi/yCz58bkqR0+j6iOOScuHsZrGkzaxQlOqHGHWPofBNMfRgpTWo5rBYY+Gd6d8oIdCGr0gfko53Ns6/P6qNWpOiZJorlJNbgxqkGHf5RtGlIlVDBF13KVKqWWdpuP1TN3wJBNP3cH0Hse+aGskOI8gBA6LQt0WQ7E1wWVBOjgeo/JallVIZ8y9zKsTTN0kxzbFPK9TXfyCTYg3gXdv4DxKEkPhbMxjaRG6EveU62i3ifp+aS1qaWJpkUvUGncukqp4WnFkcTD1PTxyr6jhh/P7+9Vyi4m+kkjnF79RH8KhiauRs6nT8usDzUqVhG8QBzMXPqugcDsW0WTJ0zd2eAvPSAisHUm8RAmP3pgdEBnmANII46m58zPRMsO2Gzx+AmPvmgBljn792nX56dURplbvcQ3qTmPkPigmumoGjRpLj46BXCtcu/ZbA8XXd0EDzUAi6vWPey8mN+YH9I81LDgCByAHMRp5gnzaeKFBgMB1u53mQPif6ERTPHdM9BPxegEC7R4jLSdOp7vXvO9ZHkjdjUPY0GMNnRmfyLt1uBI6JLtN3tcVSpHQGXePvOHRvqtAKkybG0W5963VqFblkm9KRJxvwsdYtHdFvF56qqtjWMu94bIMX43n1meZUZBEa3O/XLmJvw/IrCbcxbn1nuJNzaeHyUboOLHrZXjXl73PP6xJ8tw6J52MxLWvLT7z5y+UE+gWboklwCb7AdGLp8g7+1yWPJryx9ldjdPqaiPGeVxHGNNNfAqiq/U8LknSARHpfqoB0E8zPDuwDJ4ai3CFU8zH7wsdwzakcgPRWHPCqfvGZtFuV4+fn6UUXz3puel/yLT05qsPLaY1LnAeNxx8BJU2GByAB+X0RBR7EvmQN5j4gn74KmriWtBcTABBPHvO0A8vVQrAGzpIAPEfh3XubqutTBmdCGAjT3Zg8jMqWMku4k2vfEMH42A+RHyhazaWLAcDqXAOA4yGu+ax+PcTiafHPmPiD9AE/wASZcCRbIyPNgn5pVyXTj7Udcczbnz9FHEYZrBa54qp9UX4f4XKWKnuu03HhqIKz9RgT90eTodB1rg9GTjs/Avr3QgwxBlunBNn4Ql4aBco6pgg0LEpNHZcFJiulWaRzVJomo7K3faSvYqgSe772gjfyTjBbONFoLnS+LxoCeH1UtJWTdvSw3s/gW4eYcTm1J5aQNw16rQirOlzwWU9u7wCLwOOLz7JrjJN3awN90upsSeJdhxicS1tnPv+yz5lCvc947rAxnF1p/L4ooU2MtTZmdvJv5uJ0XWYeTmquzEaNHuj6lTdlSaX/f4Fz8A1gznvO4kQP4RuWfxzCVrscQQT9yszjniUO5ZF2txHUplUuaj6w5Kr2HFWJitE3OzO/C31I+/grqcND3m0dxu897U9dy9RqBsH9UNzHwuGjx+irc4yG7xc/vm39It5Lqnl+QjA09Tut46RHiAI8UYa24btEKSGANHAffzXS8DU7j9EUI92F4f3Xu4kAnkPsHzXHm1Nn7Xfd4G/wyhUudNNrP2iCfOSfQNHmrq7u85/GI/uj+0IBRcHy4ng7L/Lr/dU6KO0MT7NhPl1MH4lQomB5x0u4/3fzIHbjzDGASc0wLkxeOqD2Q0Vqkkd2BQzurVnz7rmNO+XNlx8Q2P5lp8HgyQHO7rdfMyTHgSL/hQOx8OKNBgq+9d7m/icZ73gMo8iqdp7bJsNFjydRW0eTrYOgc3qybLwHY7FMY0MZoBlH+dVgO0QAxFQDQGOgTKtj98pDtCvnqOdxJKHTp7tmnq9KUYxO7PbLwnOCwmSqKhIMTYcwRr5pVsr3j4Jyx1kck3GWwMOOM4VJD1uMD9RBtI433c9PNcqOJda0uiBvE6+Bmn6+CTNrXAEynFN8kE667ryCL8pM+auwTlNbnO63BDFJaOGXYh3eaB+1HgIMD09FwmR5R11+KpYe+5x3AAeJnveYkDlKnNuf1mFeYjztTzj4z8pUXHnvueFx8vioB8/d7flbyVdR9vH5NBJ8IgeQQGoz9R4OJk/dk3qViY6egH1Wfa/NWnz9U4pVI9Pl+aES7IuCbWyb+J6TA6qdRoAgcIPnB+qF9pY8o/P5LxJG/71RsWmxls7Gim4F/hO4D6Sm2OMtlZWvUERxkev0JV+z9rHMab/AHSdTuPDwWPPiT3idTo+ocfbPjyOti4WXOqHdZvidT0+KKxtQBWYGG0ep+/IBBUKBrP/AADXnyWJnWT5bBqWFdUvMN48fBMKGDc2Azu/EniSmrMOANOSKo0wCiVSyFbGEN+781U88ddwRWKqQ2QgIMSdTomWxVHc9WqjS0D4pJUYDJTurS7sb+KW4hloQZZECNAFvNBlkpuCAL2lL8sOPooHuf/Z');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbestado_candidato`
--

CREATE TABLE `tbestado_candidato` (
  `Id_estado_formula_pres` int(2) UNSIGNED ZEROFILL NOT NULL,
  `nombre_estado_formula_pres` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbestado_candidato`
--

INSERT INTO `tbestado_candidato` (`Id_estado_formula_pres`, `nombre_estado_formula_pres`) VALUES
(01, 'En Contienda'),
(02, 'Fuera de Votaciones');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbestado_de_votos`
--

CREATE TABLE `tbestado_de_votos` (
  `id_estado_voto` int(2) UNSIGNED ZEROFILL NOT NULL,
  `nombre_estado_voto` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbestado_de_votos`
--

INSERT INTO `tbestado_de_votos` (`id_estado_voto`, `nombre_estado_voto`) VALUES
(01, 'Valido'),
(02, 'Nulo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbestado_empresas`
--

CREATE TABLE `tbestado_empresas` (
  `id_estado_empresa` int(1) NOT NULL,
  `estado_empresa` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbestado_empresas`
--

INSERT INTO `tbestado_empresas` (`id_estado_empresa`, `estado_empresa`) VALUES
(1, 'Activo '),
(2, 'Inactivo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbestado_juntas`
--

CREATE TABLE `tbestado_juntas` (
  `id_estado_junta` int(2) UNSIGNED ZEROFILL NOT NULL,
  `nombre_estado_junta` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbestado_juntas`
--

INSERT INTO `tbestado_juntas` (`id_estado_junta`, `nombre_estado_junta`) VALUES
(01, 'Activa'),
(02, 'Inactiva');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbestado_miembros`
--

CREATE TABLE `tbestado_miembros` (
  `id_estado_integrante` int(2) UNSIGNED ZEROFILL NOT NULL,
  `nombre_estado_integrante` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbestado_miembros`
--

INSERT INTO `tbestado_miembros` (`id_estado_integrante`, `nombre_estado_integrante`) VALUES
(01, 'Activo '),
(02, 'Inactivo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbestado_usuarios`
--

CREATE TABLE `tbestado_usuarios` (
  `id_est_usu` int(2) UNSIGNED ZEROFILL NOT NULL,
  `nombre_est_usu` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbestado_usuarios`
--

INSERT INTO `tbestado_usuarios` (`id_est_usu`, `nombre_est_usu`) VALUES
(01, 'Activo '),
(02, 'Inactivos');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbestado_votante`
--

CREATE TABLE `tbestado_votante` (
  `id_estado_votante` int(2) UNSIGNED ZEROFILL NOT NULL,
  `nombre_estado_votante` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbestado_votante`
--

INSERT INTO `tbestado_votante` (`id_estado_votante`, `nombre_estado_votante`) VALUES
(01, 'Activo'),
(02, 'Inactivo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbgenero`
--

CREATE TABLE `tbgenero` (
  `id_genero` int(2) UNSIGNED ZEROFILL NOT NULL,
  `genero` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbgenero`
--

INSERT INTO `tbgenero` (`id_genero`, `genero`) VALUES
(01, 'Masculino'),
(02, 'Femenino');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbjrv`
--

CREATE TABLE `tbjrv` (
  `id_junta` int(4) UNSIGNED ZEROFILL NOT NULL,
  `estado_junta` int(2) UNSIGNED ZEROFILL NOT NULL,
  `integrantes_junta` int(9) UNSIGNED ZEROFILL NOT NULL,
  `jrv_mesa` int(5) UNSIGNED ZEROFILL NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbmesas_votacion`
--

CREATE TABLE `tbmesas_votacion` (
  `id_mesa_votacion` int(5) UNSIGNED ZEROFILL NOT NULL,
  `centro_votacion_mesa` int(9) UNSIGNED ZEROFILL NOT NULL,
  `Lugar` varchar(45) NOT NULL,
  `ubicacion_mesa` int(9) UNSIGNED ZEROFILL NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbmesas_votacion`
--

INSERT INTO `tbmesas_votacion` (`id_mesa_votacion`, `centro_votacion_mesa`, `Lugar`, `ubicacion_mesa`) VALUES
(00002, 000000005, 'Centro Escolar Republica de Brasil', 000000002),
(00003, 000000005, 'Centro Escolar Republica de El Salvador', 000000002),
(00004, 000000005, 'Centro Escolar Pedro Pablo Castillo', 000000002),
(00005, 000000005, 'Centro Escolar Republica de Uruguay', 000000001),
(00006, 000000005, 'Centro Escolar Republica de Guatemala', 000000004),
(00007, 000000005, 'Centro Escolar Republica de Panama', 000000002),
(00008, 000000005, 'Centro Educativo República del Perú', 000000001),
(00009, 000000005, 'Complejo Sierra Morena', 000000001);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbmiembros`
--

CREATE TABLE `tbmiembros` (
  `id_integrante` int(9) UNSIGNED ZEROFILL NOT NULL,
  `nombre_int` varchar(25) NOT NULL,
  `apelllido_int` varchar(25) NOT NULL,
  `cargo_integrante` int(2) UNSIGNED ZEROFILL NOT NULL,
  `estado_integrante` int(2) UNSIGNED ZEROFILL NOT NULL,
  `correo_miembro` varchar(150) NOT NULL,
  `telefono_miembro` varchar(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbmiembros`
--

INSERT INTO `tbmiembros` (`id_integrante`, `nombre_int`, `apelllido_int`, `cargo_integrante`, `estado_integrante`, `correo_miembro`, `telefono_miembro`) VALUES
(000000003, 'Adalberto  Francisco', 'Aguilar Paredes', 05, 01, 'dwdewqewq@gmail.com', '6978-3478');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbmunicipios`
--

CREATE TABLE `tbmunicipios` (
  `id_municipio` int(3) UNSIGNED ZEROFILL NOT NULL,
  `Nombre_mun` varchar(100) NOT NULL,
  `departamento_mun` int(2) UNSIGNED ZEROFILL NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbmunicipios`
--

INSERT INTO `tbmunicipios` (`id_municipio`, `Nombre_mun`, `departamento_mun`) VALUES
(004, 'Aguilares', 02);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbpadrones`
--

CREATE TABLE `tbpadrones` (
  `id_padron` int(9) UNSIGNED ZEROFILL NOT NULL,
  `cantidad_padron` int(5) NOT NULL,
  `votante_padron` int(5) UNSIGNED ZEROFILL NOT NULL,
  `mesa_padron` int(5) UNSIGNED ZEROFILL NOT NULL,
  `codigo_padron` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbpadrones`
--

INSERT INTO `tbpadrones` (`id_padron`, `cantidad_padron`, `votante_padron`, `mesa_padron`, `codigo_padron`) VALUES
(000000003, 5, 00002, 00008, 0),
(000000004, 5, 00001, 00008, 1),
(000000010, 0, 00001, 00002, 778766);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbpartidos_politicos`
--

CREATE TABLE `tbpartidos_politicos` (
  `id_partido` int(2) UNSIGNED ZEROFILL NOT NULL,
  `nombre_par` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbpartidos_politicos`
--

INSERT INTO `tbpartidos_politicos` (`id_partido`, `nombre_par`) VALUES
(01, 'FMLN'),
(02, 'Parlamentarios');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbpreguntas`
--

CREATE TABLE `tbpreguntas` (
  `id_pregunta` int(11) NOT NULL,
  `pregunta` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbroot`
--

CREATE TABLE `tbroot` (
  `id_root` int(2) UNSIGNED ZEROFILL NOT NULL,
  `nombres_root` varchar(25) NOT NULL,
  `apellidos_root` varchar(25) NOT NULL,
  `usuario_root` varchar(25) NOT NULL,
  `clave_root` varchar(9) NOT NULL,
  `primer_uso` int(10) NOT NULL,
  `dui_root` int(9) NOT NULL,
  `municipio_root` int(3) UNSIGNED ZEROFILL NOT NULL,
  `est_root` int(2) UNSIGNED ZEROFILL NOT NULL,
  `genero_root` int(2) UNSIGNED ZEROFILL NOT NULL,
  `correo_root` varchar(150) NOT NULL,
  `telefono_root` int(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbtipos_candidatos`
--

CREATE TABLE `tbtipos_candidatos` (
  `id_tipo_candidato` int(2) UNSIGNED ZEROFILL NOT NULL,
  `cargo` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbtipos_candidatos`
--

INSERT INTO `tbtipos_candidatos` (`id_tipo_candidato`, `cargo`) VALUES
(03, 'Presidente'),
(04, 'Vicepresidente');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbtipos_empresas`
--

CREATE TABLE `tbtipos_empresas` (
  `id_tipo_empresa` int(11) NOT NULL,
  `nombre_tipo_empresa` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbtipo_integrantes`
--

CREATE TABLE `tbtipo_integrantes` (
  `id_tipo_integrante` int(2) UNSIGNED ZEROFILL NOT NULL,
  `nombre_tipo_integrante` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbtipo_integrantes`
--

INSERT INTO `tbtipo_integrantes` (`id_tipo_integrante`, `nombre_tipo_integrante`) VALUES
(01, 'Presidente'),
(02, 'Encargado de urna'),
(03, 'Vigilante de urna'),
(04, 'Primera Vocalía '),
(05, 'Secretaría');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbtipo_usuarios`
--

CREATE TABLE `tbtipo_usuarios` (
  `id_tipo_usuario` int(2) UNSIGNED ZEROFILL NOT NULL,
  `nombre_tipo_usuario` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbtipo_usuarios`
--

INSERT INTO `tbtipo_usuarios` (`id_tipo_usuario`, `nombre_tipo_usuario`) VALUES
(01, 'Root'),
(02, 'Administrador');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbubicaciones`
--

CREATE TABLE `tbubicaciones` (
  `id_ubicacion` int(5) UNSIGNED ZEROFILL NOT NULL,
  `ubicacion` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbubicaciones`
--

INSERT INTO `tbubicaciones` (`id_ubicacion`, `ubicacion`) VALUES
(00001, 'San Salvador'),
(00002, 'San Vicente'),
(00004, 'San Miguel ');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbusuarios`
--

CREATE TABLE `tbusuarios` (
  `id_usuario` int(5) UNSIGNED ZEROFILL NOT NULL,
  `nombres_usuario` varchar(25) NOT NULL,
  `apellidos_usuario` varchar(25) NOT NULL,
  `clave_usuarios` varchar(59) DEFAULT NULL,
  `dui_usuario` varchar(10) NOT NULL,
  `municipio_usuario` int(3) UNSIGNED ZEROFILL NOT NULL,
  `tipo_usuario` int(2) UNSIGNED ZEROFILL NOT NULL,
  `est_usu` int(2) UNSIGNED ZEROFILL NOT NULL,
  `telefono_usuario` varchar(9) NOT NULL,
  `correo_usuario` varchar(150) NOT NULL,
  `genero_usuario` int(2) UNSIGNED ZEROFILL NOT NULL,
  `primer_uso` int(10) NOT NULL,
  `empresa` int(11) NOT NULL,
  `Intentos` int(1) NOT NULL,
  `usuario` varchar(25) NOT NULL,
  `logo` longtext,
  `pregunta1` int(11) NOT NULL,
  `respuesta1` varchar(50) NOT NULL,
  `pregunta2` int(11) NOT NULL,
  `respuesta2` varchar(50) NOT NULL,
  `pregunta3` int(11) NOT NULL,
  `respuesta3` varchar(50) NOT NULL,
  `pregunta4` int(11) NOT NULL,
  `respuesta4` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbusuarios`
--

INSERT INTO `tbusuarios` (`id_usuario`, `nombres_usuario`, `apellidos_usuario`, `clave_usuarios`, `dui_usuario`, `municipio_usuario`, `tipo_usuario`, `est_usu`, `telefono_usuario`, `correo_usuario`, `genero_usuario`, `primer_uso`, `empresa`, `Intentos`, `usuario`, `logo`, `pregunta1`, `respuesta1`, `pregunta2`, `respuesta2`, `pregunta3`, `respuesta3`, `pregunta4`, `respuesta4`) VALUES
(00030, 'Adalberto Francisco ', 'Aguilar Paredes', '98DD15C330FB5ABB4508347265A7F76C', '97870097-9', 004, 01, 01, '6345-9797', 'adal@gmail.com', 01, 0, 0, 0, 'arwen', '/9j/4AAQSkZJRgABAQEAAAAAAAD/2wBDAAkGBxISEhUTEhIVFRUXGBgXGBgXFxUVFRUYFxUXGBcYFRsYHSggGBolHRcVITEhJSkrLi4uGh8zODMtNygtLiv/2wBDAQoKCg4NDhoQEBstJSAlLS0tLSstLS0tLS8rLS0tLS8tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS3/wAARCAEJAL4DASIAAhEBAxEB/8QAHAAAAQUBAQEAAAAAAAAAAAAABgABAgQFBwMI/8QARhAAAQIEAwUFBAcFBwMFAAAAAQIRAAMEIRIxQQUGUWGBEyJxkaEyscHwByNCUmKy0RSS0+HxJFNjcnOCokPC0hYzNKOz/8QAGgEAAgMBAQAAAAAAAAAAAAAAAAMBAgQFBv/EACwRAAICAQQABQQBBQEAAAAAAAABAgMRBBIhMRMiMkFRFDNSYYEFI0KhscH/2gAMAwEAAhEDEQA/AAndjd6VUyytalghZT3SkBglB1Sb94+kESvo+p88c5te8j07l4o7hKHYqBLfWH8iIPFpCgznLPTTSOTffZGxpM211xcU8AfN3DpgnF2k7qpH/hE6fcGkUnF2s796X/DgomynSL5OzWBAj0pHSCGz8M+T+UJ+pt/Iv4UPgFFbgUgzmzrizKl/w7xBO4FMb4537yP4ecFkxbn1HD0iGNIZK1JBzAJAJuzwfUW/kHhQ+AbX9HdOA+Od+/L/AIcMn6O6Yv8AWzbfjR/DgzSkEak8bMf5RCqUlCSrD7I1IGfT1g+pt/IPDh8AZN3Eo0pBM2e5yGJBJ6CX6xUl7lU5UHXOAIfNNjaz4GOsEyJmJSiToOVgNAeF/OJrW6QA7m45EawuWrt6Ui6ph8AzM3Jph9ud44pf/hHmjc2mLELnNwxIcHh7HjBPLm6KF3v8GhSQACkfeOvG/wAYr9Vcl6mT4MPgGjuVT4mxzcn9pD/k5GPRG49MX786wf2kevcgjkIPeJve3S3vePVNzhzTkrK54fr/AFiHq7vyDwYfAN0u5NEr2ps8AgEHEgAHgSZfr8m6r6N6R2Eyo/el/wAON9TfOkNs+qIVhJUoKJwu+lwxOmYbwi0NZa+Mso6YeyMOV9G1Iot2lR+9L/hwlfRtRgH62ocfil8/8ODkJCQ+En/LmOkNMqJaXKyE8yQDlDvqLfyF+HH4AIfR1SAOZk9tWVLt/wDXEV/R1Ss4mTstVI/hwZrmJmIIBxJc3HuhdmwDufVoj6m38i3hx+ALl/R5THOZPH++X/DhL+j2ke0yeQ33kDjl9XBnOSSeQ9cso8ApINs3YiD6m38ifCh8AQvceluBMncnVLHn3MoE95dlpppqUJJIKAq5BN1KGgGgEdWqZLXvcu2oeOb7+AioS9vqww5Y1xp0l052Ykxd0IqOUjW3FB/Z1Mlx2pf9xEHwNg4toIBfo+vIUHb6xX5EfpBpImDAM/tXYxm1P3ZDavQj2lAO7HM2t8tr1j3noHBrXDHzipLmXGeebfLRYqlXcq4/G3OEFjNqioBRGYST5AmKlPLAubqN1HUuM40ClCjdZI4a+BeM2dKXLPdKVIcJAJLpewe1xpESTaLxNDZc0hZSlmwu1wAQQC3i+XKHrqoFaUlJJu/AFgUtzZz1jHk7bTJKysWFsQs5GSU8A7wtn1gqHmkYQVWAJszBy2thEyg1HkhYbNWelwO7fj+kVklQzuOWf8/nOHqDkyjnxxaWzBhSEKOqT5h+t/dCEsIuOZhsUhyHHjxB4GIIWknGQww8/snhxvDzEkXIY8QQ/hf9I8MON+9a4tbQOS7+XKJSAsomsMLXNydBqT5xKVMFkgO3jZ+Py8Uw7kEgl7lwCciPAchGhJllmASnzUPhESSQHqiU2d782HgNYlNqWchgRcHgRl1eITMQABU17Mw9C8eX7OlWb8u8dPdFF8sg2qesUtJLXyI0cHQ6xlJGNphHeVe9+g4AZNFJG20080yV3Cu8C+pDAK5WF486TaBmY1BhhLYLi5OaTd3U9ucaJxk45RVYTwaklRRNASGxuDwsCQrx06xprAF2uzcYypMpWIPhdsNnZIPDxaLa5xa3eIt4B2eJimlyQyxMqCDkCH6xUPfUcLP948XhK1x2SefRvGEiUm6k2FnF7xJBTmSlhStQ/teGcc336U9Ql/7sfnXHSTU2ORfxjnG/v/yEc5QP/Nca9F90Vf6Db3AR/ZlH/GV/+cuCbtGsSH4aPz4QKbgTGlKH+KfyJgxVT4gQG+MU1P3ZF6vQj3p53dF+HuivX1IJzIPW8KlRdgQLge7OLS6bPLxEILjUhcBgC7DVz8uIHtr1SzPwIsgAu2RIckvreCbZ1P2xYEJlgl1JcGYdUo/DxPQRnlEuoWpMpKZE6SSCgv2a0pte1vH3xeMXy8ENrIPbzUQ7JKkOQLnm4zMQ3dU0lIR3nKnBLBJf0zEXFVYKVIVhCQlRKibDCe7fhpeAKo2mpDpQogEMWtiv5h+H9IdRTO2Oz/ZWyyNbyGe0dtS5Zw4gpQzSjvMdXUSB0z5RQ/8AV6wGTKHWaR+VI98CMlRUL/yEOUR0of0+lLzLJjlqrH1wEczeqdn2UnqVH3mPEb0zwXEuXfN1KL884HZkeKoZ9HR+JX6iz5DCRvjOT/0EnN/rCHf/AG2iwjfVA9qlWk8ULB+AgEiWI8TFZaCh/wCP+2StTZ8nRaXfWmLYjPRyKQr3YjF2XvTTG4nyyb2XjlnzVHLRNUNYcTjqxhEv6ZS+sl1q5++Az2soTqgdnNSvEE3SoEDwY6DSCCvplIQ6FMoC+dyMj4gtHLRMSc0+UXqbbU6WCETpgSfsqONLcGU7dGiJ6CWFtl18lo6pe6OvbuVCpsnEojEO6dCw15Rokk+I8XVbWOT7H3mmiYMgskMU+wbZEaZcTHR9k7UTUB8lpBdI48ow30SreWh1dil0WFOUkKdT+Ni/OFMl90BXXMFosKAw2N/XjFevxFOdmudT56RnGlCtngNawFs7Fg5Mc734U9Qk/wCGPzrjodUjuuLnLV457vylp6P9JP51xs0X3BWo9Bp7ip+qUR/eEXy9hLQaIWfMe4wG7hg9kpv7w5Z+wmDamR4i/G/z/OF6n7si1XoRZp0kF2HoPkxlbR2njmdjLPtKCVKDPcsQG0iG3tqBA7NL4znlYNpwPwjO3VlYqlJYlgo5fhPxhcYe7Hxh5XJnQqUAZAABmZrW0bKB3fOXJlJE72JpcYwcJKQO9i4hi3WCRBATr0Z45BvtOnLJC5hmBCyH4t8AdI0VV75KOTLKW3zGHtfaxmFkuE6DU3zV8BpGMbmJLiNhn/WO3CEYRwjBKTk8stSFBIvmfkRGrrMFlS1B+IKX84u7Cl3VMUsoUCgJKRiKXJJbmcIT4KI1jXrpaQSVIJSvCVOzJcMCkaKFj79YTO/EsIlQ4yCRr0m2E9IftQcpa/KNVaWsdCR1Fo85kN3MrhGfi/CrqkwiYsKiuoQbmGCPlCaPGankIrKWdLQbgwXoRij26uMWqDFMWlFgTrws5PO0G5Bg2t3KBUyZjAOFF34qawHO7+XGN2ROUhWJLpP84JtxtlFaVSr9gnixOIvdPBRN31bhFLb+yFyVlr8FNZQytz5RzrL902pdGqNXlTj2buza5M9BdkqFlDyuOMX0pZOEm1r2cRz6mqVS1JWAX14GD6irETUhYdjYjUchGG6pwf6NFdm9HlUTASyWs19CI5xv8CKlLt/7Yyy9tcdHmzWNkt06PHON/ktUp/0x+dcM0X3SNR6DZ+j8gSFc5igPEJl/qYKqmqIDS2K1FkjnqX4AXgU+j4PKIf8A6quH3JekGux0ArmTPaDlCcrCxJ6n3CK3rN0i1XoQM7xUwQsAOTgcnVSiS5J+dIubhSXqTyQfgPjEt9A01DZFA9CYfcRf9oU33D+ZMHsa39kM9orwS1q+4kq6gWy526xyaolBSgSRq9i+ZPWOjb5VQRTqGq1JH/d8I58pdm6m2sTFtPKF00qyD3FCVu2JyymWlTlKyljbEEkpCh4hoCJU4kuY7vuwhNPIM9dsVyWyS7DK9z8I5Dvds1MmtnCWpJllWNBBDNM72ENwJIZntG/TXym2mc/UVRg/L0LY1UlCwVeyWfooKB8wOjwSLmpUkL7p7zHUkBIwqLBuPHKzmBGlkqPspf8AEqyR0ENOngWOJfUISPAX9wh06VN5Exnjg0Z01LkkgOSWdzcv9l4qrqEjUnwD+8iKEyrOiUp8A581PHkqeo/aPnDShcVOJyB9BHitZ4eo/lFRS3zjyJgAsqHIef8AOPVCU4TZL3+c+EU5csqLD+g4nlFieyE4Rmfdx626DnASXNty6UJl/s6lElIx4tFMHbgHe18hHpuhLBqAVZBKj6N8YxYJNyvbmD8IPkf5wmzMa2Opip2JM6luRNCJ5QCSFjWwCkhw3QHzgp3hkIVImAgKIClJ0YpFvnnHP9l1JTMlqZsKgXDXYhxHSKkHCpK2IY6aNHJbznJvurVcltOS7RT9oDPPk2sWd2qwS5gSsug5vkH1+ecVkrKVWuDpyirPl4VWyPpD4eeOxir63VJTXR0Ksm3Jwjl4RzTf1T1CP9IfnXBnsOsM1IcsUhi+baQG7/n+0pYv9Wm/Hvrimkjtuwyt7zWWd0p2CnWXZlq9UJEG+6E5JkzEv3h3h7j7hABu7SqXTLUBZCyVdQgD/uje3crRLnJ+6runra/LI9Im5eeT/Y+mOaTZ3rpmkylu7FQ82P6xR3Km4aiwclJHu/SCfeGnBpVA+0lleWfoTGDuHSqVVBhZlEnQBiPeRFIpy4RdSXgv9GnvrLUpMoJSS6lFkpclgALDxgRk057UIX3L97ECCkauDHbZO0aSTORTFQE1acaQQe8HIzyeyrcjFbeugp5yCSlHapSrAVDgHYsxb3ZxqelxF4fJnr1m1bcHNNpbaxgypICZTBPeHeYN5ZCOe7ySEieliCSm+rMbefwgjXMGYYBnJLj0ECspKpk1UxScOI2Cu6w0AxHhBpIPdkzXS45L0/uyEjiSfKBqfnBjWykqCUNcCwuFFz9xsf8AxA5xa2fuVOmMcCEDmAVeXe94jfOcY9sRGDl0AKZJVkknwBaJ/si/wjxUkejx02v3SlU8szJ6iQMhxPLX1jBoNjKqlNKlhEv7ynPvML8aI3wZAh+wK4j1PuDRf2ZsGZOLSpa5p1wg4R4kWHVQjpNDsjZdKxnzETJnMgjpoejwa7CrZU5IMhBCBkcOEdOMLlqMdIsqPlnF9q7qVdOgFUoYWd03CfFrP1PjApPlEO784+q1SRgLh+Ryjlf0kbryUylVEpOFQPeAyIOsVrvbeGEqljKBL6PdiS5qplRPQFSZI9k+ytZyB4gcOYgxmUyFLmq7FEuckAHAkJSuWSGJGpBa/AnhC2Ns0ydmSkqSrvntF4WxBziS76NhEayAJ+GaAxCVoPNOAkP4EQu6W7JqpgoRTB2XN46HhpHUpSsclClWdCS/B0iOWzZj5a3846DsFb0QWdEqHhhcD3RiNOp5UZHOVJAL+IHPwjd29sofs8qcgfYRitqRZXwPiIxpcvEpKB9pQHUmD/bcwS6Zd7YcIFmL2B+eEGWmmTqOcROd7BrCiYQS2K19NPnwjK39b9oQ390NGvjmR61tlY2zu/PhFDeuo7SZLVxlD86421Rzapr3RzZ5UHB+zC/6L5CV081KslTCD4dmn9T6x5bR2aaaYqXmnNCrXTp8R0jK3D2t2D4n7NSrjmybx0Su2T+1SyxAs6FZjj5GEX8WM1aeWxJvo9di1CaiSkrLkApX5M55kEGNfcfYvYylLUO/MJv+FJISOufWArc4rlVfYTAwmHCQbMbs3zrHYBKYAABgAPAQ7SV8uQnVNw8q6fJVm7OlLUla5aFqRdClJBUk/hLOIDt8dnLSszlKSJdgQojunLuuLPwHODVUk6EiKdbscTklMwuk8QCAWzYxrsgpRaM9VrhJNHEtoSAFKlWa6XexGViNDFOXsmQkk3Ay9pQvzAIfjB7tL6PZ4LyFoWl3APdW3IMx6eUCu1NnLkzMC0kEfecA+D3aMD3w45Q7Ck+OStsnd9JxKlz+wL4maxB1eN7YW1VyZoRNnonJy4KTzHEQPzJYVmpXNiUunUOLgZRq7H3RTKlzUFCViaoKCykYpbZYFZvfOLwakvMxjjKHGA021s5E4DEHAuOF4DN5tk1CkiTIV2acJJVkFKxABJOlsR8oPqBH1Mt9EgeVotyKVK8xaKxlgH1gCd0NjiVTCUuUhU4lWKaHUovzOoHD1g/2VRJlpCUhgBHvIokJyEWSWETObl2L4XRVrMowNpUSZstUtYdKgxjdqLiKUxEUReJhbYlK7BSJaXUQEgcsvdGauQaWnOL2sBT4zJlreCX8o1dqVZlqDAqN7BtPGBfYG25k6cmbVSx2a1KShKg6UJSooxXzOJJc8olvEcjVlrCPDa8lS0yZoCUhaGYADvIOE2GT2Mbm784/sE51EYQtI4d5I+JjV3zkBdPiAuggs2QyPTLygep5+HZ00AXVMSL6EgE+Psxm/Q1PfWl+ylulIKqhJP2QVHW+Q6ORFvfSpLiSFDIKUwbQgfHzi5uugSaddRMLAlhl3gnQeJtbhA3TpmVVQXLrUb8h8ABE/sZ6rHJ9IpT9nr7HtCO7iIT4gAt6wK7VUcYvkn4kx1feNMmXITIe4bDfgbqI53845XtuWEzGGTfExs0ksvBg1Sz5za3a2auZIK0DE0xQKQLsEILjjnBRsDb6pHcU6pZZ06p5pPw/rGFuHtr9nQQpIUjtCT94HCn0sLQazKWjrBiC8CzkUslb+B9r5vCb/W8mimX9tKS4NrZsynmT5U8MpQsFObOCO9zD6/oYNZii50jmewt2J0qpl/WPLe5YpJSASQRzYDrHRwheh841aTOxmPU43LDyTSdSYktQ48+EeS5S3icqn1JeNZmPaQHLmI7Rppc1BRNQlaTZlB/LgecTUto8Jij8tACeARVu1KpiVoS4eyj3lJ1ZzlHns0pKCkEHCSmxewNvRoK50pK0lCk4kqBCgciMiDACKCZRVC0MpUk3CtADk54hmPgDGG6nY9y6NlU96eXyE2zpbyRyUoeRhTp4l/aBHjAxtCpqEumUoYVX8CY8dgbNIJmLVMmTCWJUokDwTkOghIzb7h3LqHES7WKCCeBhY4gptLMw2jwm2jzVOivXVYSkwE4MuoTjmHlHjM2cibTrlCy5alLTyCnUX5ElXURd2dJsVHM3jG3kBR3wSkKSUKbUG4B5WMRPobDLkkivN3qUZAklGI4cKlk5jQgDXK8Y06tUUBBPcKsRHEs1+nvMVUqB1L5NlEMAL8HhWDfGuK6NCpqzO7OTLcpSGSn7yjmT1JHhF8zJdAggEKqFDvHNKdW+c+UU6GcpKAJSe+SRiAdbHRPDoH5xakbClo79UvDrgcYyM+P8/CIQmaS4fX/TAwzqiZqpStc+vh88oHd6KdUueUKzAHvMdDn7xSJYwU8o+KveGNzzJjn29c9UyfiUSVFIJJ8T8GjXpm95l1Tbr6wjc3S2cldFNmB8aZpGt0hCCfJyY1pe7s4jEkpw2IINi+TcYwNz9tLkS1JSEkFZUygc8KQ9vARoy5q5yz2acJU5CUlg+dnOXKKXp72M0+9VrngPtwaWdLnqE1bpKCEjESAp0mw8BHQxwjkG72x50lSaqbNTKMtQNziJGRBuzEOM9Y6pQ7QRPQmbLIUlQcN85vGrSyW3b8GPVR824uE2iLx4rnR5mp5xqMp57RnqSHGmfh8Y8+3cnx0vHnPmkvZhneKFBVhJKScifIg/Fh5QAbKV8wPCPHaNGVoJYEgEgNmDmIgiqSR09cx8YsyqhRyDa8/l4iUVJYZKeHk5tSVIKSknEEqISrNwDZ+bN8vFWdU1K3SJqJKAczdfkLRq7xUQk1SwPYnDtQ1sKwWWB54urRQpaZExWFZuG6g5H54Rys4m4S7R1ISWNyFsynBVeqnLPJRQP+MFElGEMCo+JKj5mFQUMpAsOsSn1CUiLFZT3M8ps3DcxkKqDOXbIepihtXbPaHCg21PHwjS3dpyrIc4vgr0jaQlkRR2jQCdKUlZwpZyrgRcddGie29uU1Kl5qwTolNyfnl5iOWb179zakGWjuS/ujMjmfh6mG16dy5fRnlco9dnsJ8tS1dmp8JI6aHwPGPVBz5+UCOxKvBOGL2V90+J9knr74MMA/oYRqK/DlhdHT0t/iwy+y5QpngKEpaUPYkrCLWsCSH0yiwvd5ZuqpkudceIx57O2fLmu00ImPZJBYjkQXtDVGxqpCiycQfNCnB6Ev6RnLSkt3Dx/BOs2HLkoUs1CVKFgABck/5usc+21MxTHd7fEtG/W1IAKXuc9W5eMD21B3xZnD+pjbpYtPLObq7G3tznBqbu0UyZLWZYcpVe4dinR/AxvbtyTLnFc8FCZYxsbEl2QEjU4vcYq7hTMKF3AKiUh/vBKSn3qizvAhSpneUcWFOt3z+MLueZtGihtwUT22rtKdVKwBJLq7qHtf484L9z65FEEU8xZxTCVKBPdlqyDcAWb1tFTdaiTTyTOmBllJJOqUs7ciYxdkJ/aqwFRzViPgm7eDBoVCbg8r2LzjGxOPsjrxnAxXmzkjWA6p26qTUinUygooCVZFOJhe1w5+covza8BeAqGI3AOZD6cY6Vd0J+5zJ1Sj2jVmVDOzxiTqgpWJidDlxGohp1dzitNW4tDRQXUcwTEhSbgi3Pl4iLEqWQAAotdvV0k+fyIDtj7VMhWFY+qUXIHtIP3h8R8k0lzQoOCFBQe2SxopJ0UPnkEnlV0EucjAseyXSftS1N7r9R5wE1dEU1CUFge8hwdWxpz0LKtzg8ByL3yCuP4Zg+fPMP+kDYaqtHZy1KkzgMSCFFKJhu8teHQ6K0JuGeMt+mVklJcNf8HV3OHAO028cyYl6cpmA88Kh4pPwMVZsyrnkoKFDiMJQkD8ROniY55hmSZikKCpcxBZSTZSSNDGmrb1SUdmZqsIvne9mf/b6mHfTR9gWpfugzBpaYPPmhSvuIy6nM9POMra+/swpMunSJaPC/z4vAfNVFdYh0aoxFTtlInW1a5hJWoqJ1JeKhiZEQUIuxZFYtBNsbefDg7RLKS3ezCmZsQ0Nv6QNoD3OXvj1QnUwqyqNixIbXbKt+U6XtASZw/aKSYlixWhK045an+6LgP8I0qTaH7SjsVnCohnDDFw68tfSOP6vFuRtCaj2Vnr3h6xkloX/izVHWJrE1/JuV9IZa1JZiCfeQfV4ytuHvIs31Y/MqIzdrTFF1MejavpFerqMeGzMls3e5L+sNhVKOGzO5xecG5u9TKmSVJGWI3/2pIja3bpzMnJKgVBLqL8rAe6Ku45eUsfjfqUpEE2xpPZ1C0WYoJGjlwSPQxz7pf3JI30vFZf3s2iEU2AZrIHQXPqwjI3HJCpkwJyThHW/w9Ypb2TSVpSTkH6K/oIJdwqNJpVLBY4y/MBI/nFMYiM6rBzeqoUakKGYCCM8wB+kae81ItUpE0gsCCDewUxcdWiW/FP8AWoUkPiSBa9wTk3iPOCKhkLXTJTUgIQlLEaqZ8L8AA3l0gXOAbxGMgYk7ZJk4UoUudhZOIoSlZDlyokMAA5Pvj22ZUzZqcAlye3AcgTh2ZALWUHJN9HyglpNkSky3plDGUlwrCSq1iCRa7Frj3xSpp9KXp1SAFOyiQe0ChrjN8XN/SNavljBmlTBtvBmL2didNTPVIfSWAFEclqdxzAjQ2dSqpEY6GZMqZGc2nmLxL5zKdR9lf4TY8jeLFTTyZnaUVSHQe9LUDhUkK1QeRe3DOOdy6idsmqMhaiuTmDxQrJQGhzBEXhOcunz8CpQjHtfydo2XtOXUSxNlKC0qtwLixRMB9lYyYxjb47dp6XslTlqAJUkMlSlA2LKa8c1VvOKKpTUUa0rE0f2iUSTLmFLMo/dUoE3zBBzBaLP0k7y01fIp1SVHE6ypCgy5dk2Xoq+RGYB5xsjysmaXDwZO/W80mvnIXKkGWpCcKpiiMU0fZdIsALsXJvozRgp+HxH6xQWqz6iPeRUhr+Hz5QxFD0mR5qhlVD5R5KU/KJAS1REJfPyhxyiYTEASSIaYYcWEeSjEgRiQiJh4AJCGhQ0RLolBbueD2am++fcmDZcvChCvtpVitdxkoeTwH7kp+qUp/wDqEf8AFF2g27BRwm7NyHDWOBqX/dZ06vQgb3imBc4kFxhSx4jCD8YItyFFFOvM98+4Ri7f2OQozUptqLa6sDG1ueppC3cBKnN2zAa3G0RnMTRPDrRtSGmzQSH7MWfRSs/TD6w1fQT5xZawmWNEu6uvCLux6YgFRFzc/p0j3qMSrCGLgz5BabJFOtJQSzsQ5byjz2jIWVrXZxhmAjgUi3oYJZmy0qSQoO/znGfOpUy0kB3OZJc+ukWTJyDe/W0CJdPUIfFLUAo6FKge6T5NGRvMuXW0pnBbzJTKRxUgsFp4vr/tijUbdVUJXQpljDMmoGPF7IlzMWIBs8KeMHVcumo6MhKQEpS3MnIeJJjTzXt+f/BGVPPwcXMSQYaIvHSMJEy7toTGnsjYEyoQuYkpRLQcLlz3iHYNq2sZxN0+MW9n7VXJSUpuCXbK5z9whVu/b5Oy0NufN0UamWpCig5g6ZciIilMSnzStRUrMwyTFo5xyQ8Z4JiJARFMSMXIIqMQMSVEYAGh4UKABQoUIREuiUHm4VOFSC/96r8kuDJE5iEhrDSzZaQGbhL+pI/xVfklwd0soZ5+7TjHntT92R06vQjwmgl3Dg9ddYr7FoiiYtKfYVhU2vdKm6XPlHvtfaEunllUx2Fg1ySTYJGpOfC0WdkAkCYxGIAgG5ANwDzzPWIqi/V7Ft3sFFKlkR5pFzHiatg0W5Enu3zMNYvo8KuoCRaB3bRWZayLKKS3IkZwTqpR1ilV4QCDErglAJufumiQDMmkKWRYtYDl+sYP0hbTSpSZCDZJxK8u6D5k+UE+9O3000qzFRskcTz5COTzpylqKlF1KLk8SY30QlOW+RnukoR2IZ4iRDwxjcZCD94eMMuFqPGHmZxAChNEREwYkCUM8MTCaABGImJRAwAPChQoAFCEKFFZdEoO/o8B7NbB2Uo/8UQaUU9g6rAAudLAOSdA2fWBP6OQP2ebx7RQ5ewiIb37RwIEhCi6rzP8tmT1PoOccSdTt1Divk6Cmo1ZZj7z7aNVNcEiWi0tOVtVEcT6Bhxjpu5tT21FLU9wMJ4ukt7mPWOMKVB39GG1Qla6dRYL76f8w9odQ3lHSvpSqxH2MtVj35fudEZrxKZtpCB3iB4xKrnJQh44dvvt9VTOMtJ+qSf31DMnkDYDrGKqp2PBpnNRWWdN2v8ASBTSgfrQo/dR3j6ZdYAds7/T5pIlAS08T3ln4D1gLIicuN9emhHvkyyuk+uCxPnrWSpaionUkk+seZMMYUacYEkgYRMReHeACBi/s7Zc2oUoS0vhDkkskaBzzMUTpGnsjbK6fGA+FbOAWdnZ+OZhVjkovZ2WjjPJnVdOqWopUGI+bRFJj0r6kzVlRDR4iLQzjnsiWM8Ho8M8ReEYuQIwoUKABRKIw8AChQhCEVl0Sg43NrEyqSapRLCYo217kth1NhA3WVKpi1LUXUouf0HIBh0jxp6lXZ4H7oUVNxJAF/AC3iYiVQmmlRlKfuxk7MpR+Blm0euz61UqYiYkspJBHTQ8oqrMReNAo67UbSM+VLWn2FZ/hOqD6+Ijne/VIJdUspyWEzgOGNwv/mlR/wB0ae5W3eyV2S2KF6HJ/wCf6Rk73bXRU1JMtLISnsk3cqZSlYvB1W5AQiNag8IZKbkuTEwuIggw6FNCIv4w0WTeHiAiUWARhAwiYjAA5hKzPjDGJTczEARhQhCgAUKFCeJAUPDQ8AChQoQMADmFDCHisuiUe0s26/pEibR5A26wlKtErohiJhCGEMoxIEgq8MqXqny/SIEwyzpEAPx8bRBQaHEIm0QSODCeIiHickEoYw0KABR7pkKWrChJUTokEn0jwje3d2uKZSyQO+gJdnZi9uD2vC5yai3FZZMUm8MxJ0tSThUCCNCGMRSYubarROmYgOT8bv8AGKQiYNtJtBJJPgcw0PCi5AhDw0PEgKFChAQAOIUOYUVl0ShaQxhQoruJwKE0KFBuYYERHkEmPWFBuDBAAxvbpmmlzRNqZgGE91GFar6KLJItpzvpfEhRSa3LGS0eHkaYgOcOTluYex8oZonDRZMrgi0JonDRO4MESI9HiMKDcGBNCaFCg3MMCaGaHhQbmGBmhQ8KDcwwJoUPDQbmGB4UNCgcshg//9k=', 0, '', 0, '', 0, '', 0, ''),
(00032, 'Napoleón', 'Bonaparte', 'E034FB6B66AACC1D48F445DDFB08DA98', '83740256-7', 004, 01, 01, '3085-5765', '--------', 01, 0, 0, 0, 'sire', NULL, 0, '', 0, '', 0, '', 0, '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbvotantes`
--

CREATE TABLE `tbvotantes` (
  `id_votante` int(5) UNSIGNED ZEROFILL NOT NULL,
  `nombre_votante` varchar(25) NOT NULL,
  `apellido_votante` varchar(25) NOT NULL,
  `dui_votante` varchar(10) NOT NULL,
  `discapacidad` int(6) UNSIGNED ZEROFILL NOT NULL,
  `municipio_votante` int(3) UNSIGNED ZEROFILL NOT NULL,
  `estado_votante` int(2) UNSIGNED ZEROFILL NOT NULL,
  `genero_votante` int(2) UNSIGNED ZEROFILL NOT NULL,
  `discapacidad_votante` int(6) UNSIGNED ZEROFILL NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbvotantes`
--

INSERT INTO `tbvotantes` (`id_votante`, `nombre_votante`, `apellido_votante`, `dui_votante`, `discapacidad`, `municipio_votante`, `estado_votante`, `genero_votante`, `discapacidad_votante`) VALUES
(00001, 'Adalberto  Francisco', 'Aguilar Paredes', '68768789-9', 000000, 004, 01, 01, 000000),
(00002, 'Juan Marcos', 'Hernandez Umanzor', '16527-8908', 000000, 004, 02, 01, 000000);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbvotos`
--

CREATE TABLE `tbvotos` (
  `id_voto` int(9) UNSIGNED ZEROFILL NOT NULL,
  `Valor_voto` int(1) DEFAULT NULL,
  `Fecha_voto` date DEFAULT NULL,
  `votante` int(5) UNSIGNED ZEROFILL NOT NULL,
  `estado_voto` int(2) UNSIGNED ZEROFILL NOT NULL,
  `partido_voto` int(2) UNSIGNED ZEROFILL NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tbactas`
--
ALTER TABLE `tbactas`
  ADD PRIMARY KEY (`id_acta`),
  ADD KEY `jrv` (`jrv`),
  ADD KEY `mesa_votacion` (`mesa_votacion`);

--
-- Indices de la tabla `tbcandidatos`
--
ALTER TABLE `tbcandidatos`
  ADD PRIMARY KEY (`id_candidato`),
  ADD KEY `tbformulas_presidenciales_ibfk_1` (`estado_candidato`),
  ADD KEY `tipo_candidato` (`tipo_candidato`),
  ADD KEY `tipo_candidato_2` (`tipo_candidato`),
  ADD KEY `tipo_candidato_3` (`tipo_candidato`);

--
-- Indices de la tabla `tbcentros_votacion`
--
ALTER TABLE `tbcentros_votacion`
  ADD PRIMARY KEY (`id_centro_votacion`),
  ADD KEY `id_centro_votacion` (`id_centro_votacion`),
  ADD KEY `municipio_centro_votacion` (`municipio_centro_votacion`);

--
-- Indices de la tabla `tbdepartamentos`
--
ALTER TABLE `tbdepartamentos`
  ADD PRIMARY KEY (`id_departamento`),
  ADD KEY `id_departamento` (`id_departamento`);

--
-- Indices de la tabla `tbdiscapacidades`
--
ALTER TABLE `tbdiscapacidades`
  ADD PRIMARY KEY (`id_discapacidad`),
  ADD KEY `id_discapacidad` (`id_discapacidad`);

--
-- Indices de la tabla `tbempresas`
--
ALTER TABLE `tbempresas`
  ADD PRIMARY KEY (`id_empresa`),
  ADD KEY `id_tipo_empresa` (`tipo_empresa`),
  ADD KEY `id_estado` (`estado_empresa`),
  ADD KEY `id_empresa` (`id_empresa`),
  ADD KEY `id_empresa_2` (`id_empresa`);

--
-- Indices de la tabla `tbestado_candidato`
--
ALTER TABLE `tbestado_candidato`
  ADD PRIMARY KEY (`Id_estado_formula_pres`);

--
-- Indices de la tabla `tbestado_de_votos`
--
ALTER TABLE `tbestado_de_votos`
  ADD PRIMARY KEY (`id_estado_voto`);

--
-- Indices de la tabla `tbestado_empresas`
--
ALTER TABLE `tbestado_empresas`
  ADD PRIMARY KEY (`id_estado_empresa`);

--
-- Indices de la tabla `tbestado_juntas`
--
ALTER TABLE `tbestado_juntas`
  ADD PRIMARY KEY (`id_estado_junta`);

--
-- Indices de la tabla `tbestado_miembros`
--
ALTER TABLE `tbestado_miembros`
  ADD PRIMARY KEY (`id_estado_integrante`);

--
-- Indices de la tabla `tbestado_usuarios`
--
ALTER TABLE `tbestado_usuarios`
  ADD PRIMARY KEY (`id_est_usu`),
  ADD KEY `id_est_usu` (`id_est_usu`);

--
-- Indices de la tabla `tbestado_votante`
--
ALTER TABLE `tbestado_votante`
  ADD PRIMARY KEY (`id_estado_votante`);

--
-- Indices de la tabla `tbgenero`
--
ALTER TABLE `tbgenero`
  ADD PRIMARY KEY (`id_genero`),
  ADD KEY `id_genero` (`id_genero`);

--
-- Indices de la tabla `tbjrv`
--
ALTER TABLE `tbjrv`
  ADD PRIMARY KEY (`id_junta`),
  ADD KEY `estado_junta` (`estado_junta`),
  ADD KEY `integrantes_junta` (`integrantes_junta`),
  ADD KEY `id_junta` (`id_junta`),
  ADD KEY `id_junta_2` (`id_junta`),
  ADD KEY `jrv_mesa` (`jrv_mesa`);

--
-- Indices de la tabla `tbmesas_votacion`
--
ALTER TABLE `tbmesas_votacion`
  ADD PRIMARY KEY (`id_mesa_votacion`),
  ADD KEY `centro_votacion_mesa` (`centro_votacion_mesa`),
  ADD KEY `centro_votacion_mesa_2` (`centro_votacion_mesa`),
  ADD KEY `centro_votacion_mesa_3` (`centro_votacion_mesa`),
  ADD KEY `id_mesa_votacion` (`id_mesa_votacion`),
  ADD KEY `ubicacion_mesa` (`ubicacion_mesa`);

--
-- Indices de la tabla `tbmiembros`
--
ALTER TABLE `tbmiembros`
  ADD PRIMARY KEY (`id_integrante`),
  ADD KEY `tipo_integrante` (`cargo_integrante`),
  ADD KEY `estado_integrante` (`estado_integrante`);

--
-- Indices de la tabla `tbmunicipios`
--
ALTER TABLE `tbmunicipios`
  ADD PRIMARY KEY (`id_municipio`),
  ADD KEY `departamento_mun` (`departamento_mun`);

--
-- Indices de la tabla `tbpadrones`
--
ALTER TABLE `tbpadrones`
  ADD PRIMARY KEY (`id_padron`),
  ADD KEY `votante_padron` (`votante_padron`),
  ADD KEY `mesa_padron` (`mesa_padron`);

--
-- Indices de la tabla `tbpartidos_politicos`
--
ALTER TABLE `tbpartidos_politicos`
  ADD PRIMARY KEY (`id_partido`);

--
-- Indices de la tabla `tbpreguntas`
--
ALTER TABLE `tbpreguntas`
  ADD PRIMARY KEY (`id_pregunta`);

--
-- Indices de la tabla `tbroot`
--
ALTER TABLE `tbroot`
  ADD UNIQUE KEY `clave_root` (`clave_root`),
  ADD UNIQUE KEY `clave_root_2` (`clave_root`),
  ADD KEY `municipio_root` (`municipio_root`,`est_root`,`genero_root`),
  ADD KEY `est_root` (`est_root`),
  ADD KEY `genero_root` (`genero_root`);

--
-- Indices de la tabla `tbtipos_candidatos`
--
ALTER TABLE `tbtipos_candidatos`
  ADD PRIMARY KEY (`id_tipo_candidato`),
  ADD KEY `id_tipo_candidato` (`id_tipo_candidato`),
  ADD KEY `id_tipo_candidato_2` (`id_tipo_candidato`);

--
-- Indices de la tabla `tbtipos_empresas`
--
ALTER TABLE `tbtipos_empresas`
  ADD PRIMARY KEY (`id_tipo_empresa`);

--
-- Indices de la tabla `tbtipo_integrantes`
--
ALTER TABLE `tbtipo_integrantes`
  ADD PRIMARY KEY (`id_tipo_integrante`);

--
-- Indices de la tabla `tbtipo_usuarios`
--
ALTER TABLE `tbtipo_usuarios`
  ADD PRIMARY KEY (`id_tipo_usuario`),
  ADD KEY `id_tipo_usuario` (`id_tipo_usuario`);

--
-- Indices de la tabla `tbubicaciones`
--
ALTER TABLE `tbubicaciones`
  ADD PRIMARY KEY (`id_ubicacion`),
  ADD KEY `id_ubicacion` (`id_ubicacion`);

--
-- Indices de la tabla `tbusuarios`
--
ALTER TABLE `tbusuarios`
  ADD PRIMARY KEY (`id_usuario`),
  ADD UNIQUE KEY `telefono_usuario` (`telefono_usuario`),
  ADD UNIQUE KEY `dui_usuario` (`dui_usuario`),
  ADD KEY `departamento_usuario` (`municipio_usuario`),
  ADD KEY `tipo_usuario` (`tipo_usuario`),
  ADD KEY `est_usu` (`est_usu`),
  ADD KEY `genero_usuario` (`genero_usuario`),
  ADD KEY `departamento_usuario_2` (`municipio_usuario`);

--
-- Indices de la tabla `tbvotantes`
--
ALTER TABLE `tbvotantes`
  ADD PRIMARY KEY (`id_votante`),
  ADD UNIQUE KEY `dui_votante` (`dui_votante`),
  ADD KEY `municipio_votante` (`municipio_votante`),
  ADD KEY `estado_votante` (`estado_votante`),
  ADD KEY `genero_votante` (`genero_votante`),
  ADD KEY `discapacidad_votante` (`discapacidad_votante`),
  ADD KEY `discapacidad` (`discapacidad`);

--
-- Indices de la tabla `tbvotos`
--
ALTER TABLE `tbvotos`
  ADD PRIMARY KEY (`id_voto`),
  ADD KEY `estado_voto` (`estado_voto`),
  ADD KEY `partido_voto` (`partido_voto`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tbactas`
--
ALTER TABLE `tbactas`
  MODIFY `id_acta` int(6) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbcandidatos`
--
ALTER TABLE `tbcandidatos`
  MODIFY `id_candidato` int(2) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `tbcentros_votacion`
--
ALTER TABLE `tbcentros_votacion`
  MODIFY `id_centro_votacion` int(9) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `tbdepartamentos`
--
ALTER TABLE `tbdepartamentos`
  MODIFY `id_departamento` int(2) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tbdiscapacidades`
--
ALTER TABLE `tbdiscapacidades`
  MODIFY `id_discapacidad` int(6) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `tbempresas`
--
ALTER TABLE `tbempresas`
  MODIFY `id_empresa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `tbestado_candidato`
--
ALTER TABLE `tbestado_candidato`
  MODIFY `Id_estado_formula_pres` int(2) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tbestado_de_votos`
--
ALTER TABLE `tbestado_de_votos`
  MODIFY `id_estado_voto` int(2) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tbestado_empresas`
--
ALTER TABLE `tbestado_empresas`
  MODIFY `id_estado_empresa` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tbestado_juntas`
--
ALTER TABLE `tbestado_juntas`
  MODIFY `id_estado_junta` int(2) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tbestado_miembros`
--
ALTER TABLE `tbestado_miembros`
  MODIFY `id_estado_integrante` int(2) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tbestado_usuarios`
--
ALTER TABLE `tbestado_usuarios`
  MODIFY `id_est_usu` int(2) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tbestado_votante`
--
ALTER TABLE `tbestado_votante`
  MODIFY `id_estado_votante` int(2) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tbgenero`
--
ALTER TABLE `tbgenero`
  MODIFY `id_genero` int(2) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tbjrv`
--
ALTER TABLE `tbjrv`
  MODIFY `id_junta` int(4) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbmesas_votacion`
--
ALTER TABLE `tbmesas_votacion`
  MODIFY `id_mesa_votacion` int(5) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `tbmiembros`
--
ALTER TABLE `tbmiembros`
  MODIFY `id_integrante` int(9) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `tbmunicipios`
--
ALTER TABLE `tbmunicipios`
  MODIFY `id_municipio` int(3) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `tbpadrones`
--
ALTER TABLE `tbpadrones`
  MODIFY `id_padron` int(9) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de la tabla `tbpartidos_politicos`
--
ALTER TABLE `tbpartidos_politicos`
  MODIFY `id_partido` int(2) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tbpreguntas`
--
ALTER TABLE `tbpreguntas`
  MODIFY `id_pregunta` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbtipos_candidatos`
--
ALTER TABLE `tbtipos_candidatos`
  MODIFY `id_tipo_candidato` int(2) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `tbtipos_empresas`
--
ALTER TABLE `tbtipos_empresas`
  MODIFY `id_tipo_empresa` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbtipo_integrantes`
--
ALTER TABLE `tbtipo_integrantes`
  MODIFY `id_tipo_integrante` int(2) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `tbtipo_usuarios`
--
ALTER TABLE `tbtipo_usuarios`
  MODIFY `id_tipo_usuario` int(2) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tbubicaciones`
--
ALTER TABLE `tbubicaciones`
  MODIFY `id_ubicacion` int(5) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `tbusuarios`
--
ALTER TABLE `tbusuarios`
  MODIFY `id_usuario` int(5) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT de la tabla `tbvotantes`
--
ALTER TABLE `tbvotantes`
  MODIFY `id_votante` int(5) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tbvotos`
--
ALTER TABLE `tbvotos`
  MODIFY `id_voto` int(9) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tbactas`
--
ALTER TABLE `tbactas`
  ADD CONSTRAINT `tbactas_ibfk_1` FOREIGN KEY (`jrv`) REFERENCES `tbjrv` (`id_junta`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbactas_ibfk_2` FOREIGN KEY (`mesa_votacion`) REFERENCES `tbmesas_votacion` (`id_mesa_votacion`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `tbcandidatos`
--
ALTER TABLE `tbcandidatos`
  ADD CONSTRAINT `tbcandidatos_ibfk_1` FOREIGN KEY (`estado_candidato`) REFERENCES `tbestado_candidato` (`Id_estado_formula_pres`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbcandidatos_ibfk_2` FOREIGN KEY (`tipo_candidato`) REFERENCES `tbtipos_candidatos` (`id_tipo_candidato`);

--
-- Filtros para la tabla `tbcentros_votacion`
--
ALTER TABLE `tbcentros_votacion`
  ADD CONSTRAINT `tbcentros_votacion_ibfk_1` FOREIGN KEY (`municipio_centro_votacion`) REFERENCES `tbmunicipios` (`id_municipio`);

--
-- Filtros para la tabla `tbjrv`
--
ALTER TABLE `tbjrv`
  ADD CONSTRAINT `tbjrv_ibfk_1` FOREIGN KEY (`estado_junta`) REFERENCES `tbestado_juntas` (`id_estado_junta`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbjrv_ibfk_2` FOREIGN KEY (`integrantes_junta`) REFERENCES `tbmiembros` (`id_integrante`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbjrv_ibfk_3` FOREIGN KEY (`jrv_mesa`) REFERENCES `tbmesas_votacion` (`id_mesa_votacion`);

--
-- Filtros para la tabla `tbmesas_votacion`
--
ALTER TABLE `tbmesas_votacion`
  ADD CONSTRAINT `tbmesas_votacion_ibfk_1` FOREIGN KEY (`centro_votacion_mesa`) REFERENCES `tbcentros_votacion` (`id_centro_votacion`),
  ADD CONSTRAINT `tbmesas_votacion_ibfk_2` FOREIGN KEY (`ubicacion_mesa`) REFERENCES `tbubicaciones` (`id_ubicacion`);

--
-- Filtros para la tabla `tbmiembros`
--
ALTER TABLE `tbmiembros`
  ADD CONSTRAINT `tbmiembros_ibfk_1` FOREIGN KEY (`cargo_integrante`) REFERENCES `tbtipo_integrantes` (`id_tipo_integrante`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbmiembros_ibfk_2` FOREIGN KEY (`estado_integrante`) REFERENCES `tbestado_miembros` (`id_estado_integrante`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `tbmunicipios`
--
ALTER TABLE `tbmunicipios`
  ADD CONSTRAINT `tbmunicipios_ibfk_1` FOREIGN KEY (`departamento_mun`) REFERENCES `tbdepartamentos` (`id_departamento`);

--
-- Filtros para la tabla `tbpadrones`
--
ALTER TABLE `tbpadrones`
  ADD CONSTRAINT `tbpadrones_ibfk_2` FOREIGN KEY (`mesa_padron`) REFERENCES `tbmesas_votacion` (`id_mesa_votacion`),
  ADD CONSTRAINT `tbpadrones_ibfk_3` FOREIGN KEY (`votante_padron`) REFERENCES `tbvotantes` (`id_votante`);

--
-- Filtros para la tabla `tbroot`
--
ALTER TABLE `tbroot`
  ADD CONSTRAINT `tbroot_ibfk_1` FOREIGN KEY (`genero_root`) REFERENCES `tbgenero` (`id_genero`),
  ADD CONSTRAINT `tbroot_ibfk_2` FOREIGN KEY (`municipio_root`) REFERENCES `tbmunicipios` (`id_municipio`),
  ADD CONSTRAINT `tbroot_ibfk_3` FOREIGN KEY (`est_root`) REFERENCES `tbtipo_usuarios` (`id_tipo_usuario`);

--
-- Filtros para la tabla `tbusuarios`
--
ALTER TABLE `tbusuarios`
  ADD CONSTRAINT `tbusuarios_ibfk_3` FOREIGN KEY (`tipo_usuario`) REFERENCES `tbtipo_usuarios` (`id_tipo_usuario`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbusuarios_ibfk_4` FOREIGN KEY (`est_usu`) REFERENCES `tbestado_usuarios` (`id_est_usu`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbusuarios_ibfk_5` FOREIGN KEY (`genero_usuario`) REFERENCES `tbgenero` (`id_genero`),
  ADD CONSTRAINT `tbusuarios_ibfk_6` FOREIGN KEY (`municipio_usuario`) REFERENCES `tbmunicipios` (`id_municipio`);

--
-- Filtros para la tabla `tbvotantes`
--
ALTER TABLE `tbvotantes`
  ADD CONSTRAINT `tbvotantes_ibfk_3` FOREIGN KEY (`estado_votante`) REFERENCES `tbestado_votante` (`id_estado_votante`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbvotantes_ibfk_4` FOREIGN KEY (`genero_votante`) REFERENCES `tbgenero` (`id_genero`),
  ADD CONSTRAINT `tbvotantes_ibfk_5` FOREIGN KEY (`municipio_votante`) REFERENCES `tbmunicipios` (`id_municipio`);

--
-- Filtros para la tabla `tbvotos`
--
ALTER TABLE `tbvotos`
  ADD CONSTRAINT `tbvotos_ibfk_1` FOREIGN KEY (`estado_voto`) REFERENCES `tbestado_de_votos` (`id_estado_voto`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbvotos_ibfk_2` FOREIGN KEY (`partido_voto`) REFERENCES `tbpartidos_politicos` (`id_partido`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
