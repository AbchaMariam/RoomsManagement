# Stage 1 - Build the Angular application with SSR
FROM node:18-alpine AS builder
WORKDIR /app
COPY package.json package-lock.json ./
RUN npm i

COPY . ./
RUN npm run build:ssr

# Stage 2 - Serve the Angular application with Express
FROM node:18-alpine
WORKDIR /app
COPY --from=builder /app/dist /app/dist
EXPOSE 4200
CMD ["node", "dist/RoomsManagement.UI/server/server.mjs"]
