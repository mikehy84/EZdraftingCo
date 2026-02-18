export const API_ROUTES = {
  persons: {
    base: '/api/persons/all',
    qdc: '/api/persons/qdc',
    byId: (id) => `/api/persons/${id}`,
  },

  taskDetails: {
    base: '/api/taskdetails',
    byId: (id) => `/api/taskdetails/${id}`,
  },

  taskAssignments: {
    base: '/api/taskAssignments',
    byId: (id) => `/api/taskAssignments/${id}`,
  },

  companies: {
    base: '/api/companies',
    byId: (id) => `/api/companies/${id}`,
  }
};
