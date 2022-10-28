export default {
  profileNavigation: {
    items: [
      {
        name: "Profile",
        url: "/?path=/story/5-pages-member-profile--member-profile",
        isActive: true,
      },
      {
        name: "Interests",
        url: "/?path=/story/5-pages-member-interests--member-interests",
        isActive: false,
      },
      {
        name: "Email Preferences",
        url: "/?path=/story/5-pages-member-email--member-email",
        isActive: false,
      },
      {
        name: "Account Security",
        url: "/?path=/story/5-pages-member-account--member-account",
        isActive: false,
      },
    ],
  },
  profileHeading: {
    title: "Profile",
    subtitle:
      "Concise Description - Complete your profile below in order to enhance your website experience",
    isProfile: true,
  },
  profileInfo: {
    firstName: "Margaret",
    lastName: "Allen",
    profileTitle: 'Structural Engineer at <a href="#">Phantom Screens</a>',
    profileInfo: {
      Email: "jeff.preussner@velir.com",
      Phone: "5552221111",
      Address: "212 Elm Street, Somerville, MA 02144",
    },
    profileSocial: {
      linkedin: "http://linkedin.com",
      facebook: "http://facebook.com",
      twitter: "http://twitter.com",
    },
    profileImage: {
      orientation: "",
      srcset: `
        https://via.placeholder.com/150x150/9E9E9E/757575?text=1x1+Large+1x+150x150 150w,
        https://via.placeholder.com/300x300/9E9E9E/757575?text=1x1+Large+1x+300x300 300w,
      `,
      alt: "",

      description: "",
    },
  },
  profilePhoto: {
    legendTitle: "Profile Photo",
    legendBody: "Lorem ipsum dolor sit amet, consectetur adipscing elit.",
    messageTitle: "",
    messageBody: "",
    messageIcon: "",
    use50: true,
    fields: [
      {
        id: "profile-photo",
        error: false,
        errorMsg:
          "The file you attemped to upload is an unsupported file type. Please upload a PNG or JPG.",
        name: "profile-photo",
        label: "Profile Photo",
        required: false,
        showPassword: false,
        type: "file",
        validationType: "file",
        helperText:
          "A 300x300 square image format of PNG, JPG, or JPEG is recommended.",
      },
    ],
  },
  personalInfo: {
    legendTitle: "Personal Information",
    legendBody:
      "Maecenas faucibus mollis interdum. Lorem ipsum dolor sit amet, consectetur adipscing elit.",
    messageTitle: "Optional Form Group MEssage/Icon",
    messageBody: "Sit phareta adipiscing condeimentum bibendum",
    messageIcon: "info-circle",
    bio: "<p><strong>Lorem ipsum</strong> dolor sit amet, consectetur adipiscing elit. Suspendisse vitae neque et dolor faucibus ullamcorper nec vel nisi. Pellentesque ut felis nec est semper interdum a sed justo. Sed tempus efficitur vehicula. Phasellus in arcu sit amet nisi tincidunt condimentum. Etiam accumsan pulvinar mi, eu congue enim. Nam dapibus vel purus sit amet maximus. Nulla sodales tellus eu leo consectetur, in pellentesque nulla aliquet. Sed maximus sollicitudin dignissim.</p><p>Vestibulum pulvinar ipsum venenatis fringilla bibendum. Nunc erat est, suscipit non lectus at, lacinia imperdiet dolor. Nam at odio ac lorem feugiat luctus vitae vitae purus. Fusce porta finibus sem, gravida malesuada justo malesuada vel. Donec hendrerit lacus efficitur sem vestibulum, eu ultricies mauris tempor. Curabitur at commodo libero. Vestibulum auctor erat in quam convallis, in rhoncus risus rutrum. Integer ut elementum augue, a tincidunt eros. Suspendisse tortor magna, eleifend sed arcu sit amet, ultricies porttitor velit.</p><p>Integer feugiat velit est, sit amet sagittis ipsum venenatis nec. Donec lobortis, arcu vehicula tristique pellentesque, metus purus fringilla lorem, in mollis enim erat sed purus. Proin fringilla lorem nisl, vitae facilisis arcu elementum a. Cras vel pulvinar neque. Curabitur dapibus eros sed nulla ullamcorper gravida. Integer eget finibus ante, eu posuere nisl. Aliquam sed massa elit. Maecenas eu sapien nisi. Donec venenatis dolor justo, et dictum arcu posuere nec. Etiam nibh sem, gravida eu tincidunt viverra, egestas fermentum ex. Integer dapibus, elit a gravida bibendum, quam lacus facilisis justo, eget mollis odio lacus sit amet enim. Duis pharetra ut nisl sed pulvinar. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.</p><p>Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Quisque dignissim tortor ut sapien egestas efficitur. Fusce laoreet id eros a condimentum. Etiam finibus dolor in lorem tempus maximus. Donec nisi libero, pharetra vehicula justo a, egestas iaculis sem. Integer quis tortor mattis, lobortis magna eu, sollicitudin ipsum. Fusce ultrices quis libero eget eleifend. Mauris odio diam, dignissim quis pharetra eu, eleifend ut erat. Vivamus semper ultricies nulla eget interdum. Nunc ac leo dignissim, congue tortor vitae, commodo arcu. Suspendisse fringilla ornare blandit.</p><p>Praesent laoreet, sapien sed congue elementum, ex felis sagittis nisi, id consectetur lorem ante at enim. Nunc ultrices egestas ante, eget aliquet urna vestibulum in. Vestibulum quis fermentum nibh, vel sodales metus. Nulla nec dolor nisl. Duis gravida enim quam, vitae lacinia eros semper quis. Cras orci sapien, imperdiet non metus pharetra, congue laoreet quam. Vestibulum tortor arcu, dignissim euismod rutrum sed, fringilla vel elit. Phasellus a tortor convallis, condimentum orci ut, ultrices sapien. Maecenas eu nisl congue, eleifend nulla quis, pharetra leo. Pellentesque fringilla, odio a condimentum iaculis, diam lectus ullamcorper tellus, sed euismod mi nulla vitae odio. Curabitur vehicula sapien erat, in cursus dolor laoreet a. Duis egestas magna ut leo maximus, sit amet sodales urna auctor. Nam rhoncus velit pellentesque vehicula euismod.</p><p>Suspendisse sed tempor ligula, eu commodo ipsum. Donec dui magna, fermentum nec egestas sed, tempus eu ex. Praesent quam mi, euismod fermentum magna sit amet, pharetra elementum ipsum. Proin facilisis, lectus porttitor condimentum dapibus, erat arcu cursus erat, vel pretium augue mauris nec risus. Duis at dapibus enim. Phasellus vel nunc mollis lectus porta tristique vitae non ligula. Phasellus dapibus, orci id placerat faucibus, est risus eleifend turpis, vel consequat nibh quam in dui. Donec ultrices urna eu lectus ullamcorper maximus. Nam vitae iaculis purus, vehicula pulvinar libero. Phasellus nec nisl a ex vestibulum auctor. Donec congue iaculis ullamcorper. Nulla eu felis vitae lacus laoreet placerat sed sed leo. Cras ut purus at dui consectetur imperdiet.</p><p>Sed quis iaculis massa. Fusce sodales a ipsum sed faucibus. Donec rutrum, est sed efficitur sagittis, odio neque pretium justo, non consequat enim nisi et metus. Nulla massa purus, varius ac tincidunt mollis, aliquam eu nisi. Ut fermentum ac felis et vestibulum. Donec at tincidunt arcu. Curabitur lobortis pellentesque eros, ac mollis mi commodo vel. Sed et sagittis ipsum.</p>",
    use50: true,
    fields: [
      {
        error: false,
        errorMsg: "First Name is required",
        id: "first-name",
        label: "First Name",
        name: "first-name",
        placeholder: "",
        required: true,
        showPassword: false,
        type: "text",
        validationType: "text",
        helperText: "",
      },
      {
        error: false,
        errorMsg: "Last Name is required",
        id: "last-name",
        label: "Last Name",
        name: "last-name",
        placeholder: "",
        required: true,
        showPassword: false,
        type: "text",
        validationType: "text",
        helperText: "",
      },
      {
        error: false,
        errorMsg: "",
        id: "company-name",
        label: "Company Name",
        name: "company-name",
        placeholder: "",
        required: false,
        showPassword: false,
        type: "text",
        validationType: "text",
        helperText: "",
      },
      {
        autocomplete: "",
        error: false,
        errorMsg: "Please enter a valid URL",
        label: "Company Website URL",
        name: "company-website",
        placeholder: "http://www.website.com",
        showPassword: false,
        type: "text",
        required: true,
        validationType: "website",
        helperText: "",
      },
      {
        autocomplete: "",
        error: false,
        errorMsg: "",
        label: "Job Title",
        name: "job-title",
        placeholder: "",
        required: false,
        showPassword: false,
        type: "text",
        validationType: "text",
        helperText: "",
      },
    ],
  },
  contactInfo: {
    legendTitle: "Contact Information",
    legendBody:
      "Form Group general description - Maecenas faucibus mollis interdum. Lorem ipsum dolor sit amet, consectetur adipscing elit.",
    messageTitle: "Optional Form Group MEssage/Icon",
    messageBody: "Sit phareta adipiscing condeimentum bibendum",
    messageIcon: "info-circle",
    use50: true,
    fields: [
      {
        autocomplete: "",
        error: false,
        errorMsg: "Please enter a valid email address",
        label: "Email Address",
        name: "email-address",
        value: "Jane.Doe@email.com",
        required: true,
        showPassword: false,
        type: "email",
        validationType: "email",
        helperText:
          "Updating your Email Address will also update your Email Address within your Profile",
        fullWidth: true,
        readonly: true,
      },
      {
        autocomplete: "",
        error: false,
        errorMsg: "Please enter a 9 digit phone number",
        label: "Phone Number",
        name: "phone-number",
        placeholder: "(123) 456-7890",
        required: true,
        type: "tel",
        validationType: "tel",
      },
      {
        error: false,
        errorMsg: "Please enter a valid phone extension",
        id: "phone-extension",
        label: "Phone Extension",
        name: "phone-extension",
        type: "text",
        required: true,
        validationType: "extension",
      },
    ],
  },
  addressInfo: {
    legendTitle: "Address Information",
    legendBody:
      "Maecenas faucibus mollis interdum. Lorem ipsum dolor sit amet, consectetur adipscing elit.",
    messageTitle: "Optional Form Group MEssage/Icon",
    messageBody: "Sit phareta adipiscing condeimentum bibendum",
    messageIcon: "info-circle",
    use50: true,
    countrySelect: [
      {
        jsClass: "js-country-dropdown",
        autocomplete: "",
        error: false,
        errorMsg: "",
        label: "Country",
        name: "country",
        readonly: false,
        required: true,
        validationType: "text",
        matchName: "",
        fullWidth: true,
        options: [{ text: "Select Country", value: "USA" }],
      },
    ],
    fields: [
      {
        autocomplete: "",
        error: false,
        errorMsg: "A Street Address is required",
        label: "Street Address 01",
        name: "street-address-1",
        placeholder: "",
        required: true,
        showPassword: false,
        type: "text",
        validationType: "text",
        helperText: "",
        fullWidth: true,
      },
      {
        autocomplete: "",
        error: false,
        errorMsg: "",
        label: "Street Address 02",
        name: "street-address-2",
        placeholder: "",
        required: false,
        showPassword: false,
        type: "text",
        validationType: "text",
        helperText: "",
        fullWidth: true,
      },
      {
        autocomplete: "",
        error: false,
        errorMsg: "A City is required",
        label: "City",
        name: "city",
        placeholder: "",
        required: true,
        showPassword: false,
        type: "text",
        validationType: "text",
        helperText: "",
      },
    ],
    stateSelect: [
      {
        jsClass: "js-province-dropdown",
        autocomplete: "",
        error: false,
        errorMsg: "",
        label: "State or Province",
        name: "state-or-province",
        readonly: false,
        required: true,
        validationType: "text",
        matchName: "",
        options: [{ text: "Select State or Province", value: "MA" }],
      },
    ],
    zipInput: [
      {
        autocomplete: "",
        error: false,
        errorMsg: "A Zip / Postal Code is required",
        label: "Zip / Postal Code",
        name: "zip",
        required: true,
        type: "text",
        validationType: "zip",
      },
    ],
  },
  socialAccounts: {
    legendTitle: "Social Accounts",
    legendBody:
      "Maecenas faucibus mollis interdum. Lorem ipsum dolor sit amet, consectetur adipscing elit.",
    messageTitle: "Optional Form Group MEssage/Icon",
    messageBody: "Sit phareta adipiscing condeimentum bibendum",
    messageIcon: "info-circle",
    use50: true,
    fields: [
      {
        autocomplete: "",
        error: false,
        errorMsg: "Please enter a valid URL",
        label: "LinkedIn Profile URL",
        name: "linkedin",
        placeholder: "http://www.website.com",
        type: "text",
        required: true,
        validationType: "website",
        helperText: "",
      },
      {
        autocomplete: "",
        error: false,
        errorMsg: "Please enter a valid URL",
        label: "Facebook Profile URL",
        name: "facebook",
        placeholder: "http://www.website.com",
        type: "text",
        required: true,
        validationType: "website",
        helperText: "",
      },
      {
        autocomplete: "",
        error: false,
        errorMsg: "Please enter a valid URL",
        label: "Twitter Profile URL",
        name: "twitter",
        placeholder: "http://www.website.com",
        type: "text",
        required: true,
        validationType: "website",
        helperText: "",
      },
    ],
  },

  shortBio: {
    legendTitle: "Short Biography",
    legendBody:
      "Form Group general description - Maecenas faucibus mollis interdum. Lorem ipsum dolor sit amet, consectetur adipscing elit.",
    messageTitle: "Optional Form Group MEssage/Icon",
    messageBody: "Sit phareta adipiscing condeimentum bibendum",
    messageIcon: "info-circle",
    use50: true,
    fields: [
      {
        extraClass: "js-rte-content",
        autocomplete: "",
        error: false,
        errorMsg: "Your Short Bio is too long",
        id: "sample-text",
        label: "Short Biography",
        name: "sample-text",
        type: "hidden",
        placeholder: "",
        required: true,
        maxLength: 2600,
        validationType: "text-length",
        helperText: "",
        value:
          "<p><strong>Lorem ipsum</strong> dolor sit amet, consectetur adipiscing elit. Suspendisse vitae neque et dolor faucibus ullamcorper nec vel nisi. Pellentesque ut felis nec est semper interdum a sed justo. Sed tempus efficitur vehicula. Phasellus in arcu sit amet nisi tincidunt condimentum. Etiam accumsan pulvinar mi, eu congue enim. Nam dapibus vel purus sit amet maximus. Nulla sodales tellus eu leo consectetur, in pellentesque nulla aliquet. Sed maximus sollicitudin dignissim.</p><p>Vestibulum pulvinar ipsum venenatis fringilla bibendum. Nunc erat est, suscipit non lectus at, lacinia imperdiet dolor. Nam at odio ac lorem feugiat luctus vitae vitae purus. Fusce porta finibus sem, gravida malesuada justo malesuada vel. Donec hendrerit lacus efficitur sem vestibulum, eu ultricies mauris tempor. Curabitur at commodo libero. Vestibulum auctor erat in quam convallis, in rhoncus risus rutrum. Integer ut elementum augue, a tincidunt eros. Suspendisse tortor magna, eleifend sed arcu sit amet, ultricies porttitor velit.</p><p>Integer feugiat velit est, sit amet sagittis ipsum venenatis nec. Donec lobortis, arcu vehicula tristique pellentesque, metus purus fringilla lorem, in mollis enim erat sed purus. Proin fringilla lorem nisl, vitae facilisis arcu elementum a. Cras vel pulvinar neque. Curabitur dapibus eros sed nulla ullamcorper gravida. Integer eget finibus ante, eu posuere nisl. Aliquam sed massa elit. Maecenas eu sapien nisi. Donec venenatis dolor justo, et dictum arcu posuere nec. Etiam nibh sem, gravida eu tincidunt viverra, egestas fermentum ex. Integer dapibus, elit a gravida bibendum, quam lacus facilisis justo, eget mollis odio lacus sit amet enim. Duis pharetra ut nisl sed pulvinar. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.</p><p>Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Quisque dignissim tortor ut sapien egestas efficitur. Fusce laoreet id eros a condimentum. Etiam finibus dolor in lorem tempus maximus. Donec nisi libero, pharetra vehicula justo a, egestas iaculis sem. Integer quis tortor mattis, lobortis magna eu, sollicitudin ipsum. Fusce ultrices quis libero eget eleifend. Mauris odio diam, dignissim quis pharetra eu, eleifend ut erat. Vivamus semper ultricies nulla eget interdum. Nunc ac leo dignissim, congue tortor vitae, commodo arcu. Suspendisse fringilla ornare blandit.</p><p>Praesent laoreet, sapien sed congue elementum, ex felis sagittis nisi, id consectetur lorem ante at enim. Nunc ultrices egestas ante, eget aliquet urna vestibulum in. Vestibulum quis fermentum nibh, vel sodales metus. Nulla nec dolor nisl. Duis gravida enim quam, vitae lacinia eros semper quis. Cras orci sapien, imperdiet non metus pharetra, congue laoreet quam. Vestibulum tortor arcu, dignissim euismod rutrum sed, fringilla vel elit. Phasellus a tortor convallis, condimentum orci ut, ultrices sapien. Maecenas eu nisl congue, eleifend nulla quis, pharetra leo. Pellentesque fringilla, odio a condimentum iaculis, diam lectus ullamcorper tellus, sed euismod mi nulla vitae odio. Curabitur vehicula sapien erat, in cursus dolor laoreet a. Duis egestas magna ut leo maximus, sit amet sodales urna auctor. Nam rhoncus velit pellentesque vehicula euismod.</p><p>Suspendisse sed tempor ligula, eu commodo ipsum. Donec dui magna, fermentum nec egestas sed, tempus eu ex. Praesent quam mi, euismod fermentum magna sit amet, pharetra elementum ipsum. Proin facilisis, lectus porttitor condimentum dapibus, erat arcu cursus erat, vel pretium augue mauris nec risus. Duis at dapibus enim. Phasellus vel nunc mollis lectus porta tristique vitae non ligula. Phasellus dapibus, orci id placerat faucibus, est risus eleifend turpis, vel consequat nibh quam in dui. Donec ultrices urna eu lectus ullamcorper maximus. Nam vitae iaculis purus, vehicula pulvinar libero. Phasellus nec nisl a ex vestibulum auctor. Donec congue iaculis ullamcorper. Nulla eu felis vitae lacus laoreet placerat sed sed leo. Cras ut purus at dui consectetur imperdiet.</p><p>Sed quis iaculis massa. Fusce sodales a ipsum sed faucibus. Donec rutrum, est sed efficitur sagittis, odio neque pretium justo, non consequat enim nisi et metus. Nulla massa purus, varius ac tincidunt mollis, aliquam eu nisi. Ut fermentum ac felis et vestibulum. Donec at tincidunt arcu. Curabitur lobortis pellentesque eros, ac mollis mi commodo vel. Sed et sagittis ipsum.</p>",
      },
    ],
  },
  profileFooter: {
    title: "",
    subtitle: "",
    isProfile: true,
  },
  statusMessage: {
    color: "",
    icon: "notification-circle",
    message:
      "Form message area for important messages regarding validation and such! <a href='#'>These should include jump links</a>",
  },
};
