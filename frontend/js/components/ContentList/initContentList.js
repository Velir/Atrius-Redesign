import { Accordion } from "../../accordion.js";

export default () => {
  document.querySelectorAll(".js-list-item-overflow").forEach((el, i) => {
    Accordion(el, i);

    const firstNewItem = el.querySelectorAll(".content-list__item")[0];
    firstNewItem.setAttribute("tabIndex", "-1");

    el.querySelector(".js-accordion-link").addEventListener("click", (e) => {
      window.setTimeout(() => {
        firstNewItem.focus();
      }, 600);
    });
  });
};
