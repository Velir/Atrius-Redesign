import NavMenu from "./navigation/NavMenu.js";

const initSearchMenu = (el) => {
  const onClose = () => {};
  const onOpen = () => {};

  NavMenu({
    animationDelay: 2000,
    closed: true,
    direction: "",
    menuButton: ".js-search-menu-button",
    menuCloseButton: ".js-search-menu-close-button",
    menuContainer: ".js-search-menu-content",
    navigationLink: "input, button",
    openClass: "is-open",
    onClose: onClose,
    onOpen: onOpen,
    parent: el,
  });
};

export default initSearchMenu;
